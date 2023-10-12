using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using XyloCode.ThirdPartyServices.Pecom.Calculation.Req;
using XyloCode.ThirdPartyServices.Pecom.Calculation.Res;
using XyloCode.ThirdPartyServices.Pecom.Helpers;
using XyloCode.ThirdPartyServices.Pecom.Models;
using XyloCode.ThirdPartyServices.Pecom.Requests;
using XyloCode.ThirdPartyServices.Pecom.Responses;

namespace XyloCode.ThirdPartyServices.Pecom
{
    public sealed class PecClient
    {
        const string baseUri = "https://kabinet.pecom.ru";

        private readonly HttpClient basicClient, bearerClient;
        private readonly JsonSerializerOptions jso;
        private long expiresIn = 0;

        public PecClient(
            string login,
            string apiKey,
            string baseUri = baseUri,
            HttpMessageHandler httpMessageHandler = null,
            bool disposeHandler = true)
        {

            if (httpMessageHandler is null)
            {
                basicClient = new HttpClient();
                bearerClient = new HttpClient();
            }
            else
            {
                basicClient = new HttpClient(httpMessageHandler, disposeHandler);
                bearerClient = new HttpClient(httpMessageHandler, disposeHandler);
            }


            basicClient.BaseAddress = new Uri(baseUri);
            bearerClient.BaseAddress = new Uri(baseUri);

            var basicAuth = Convert.ToBase64String(Encoding.UTF8.GetBytes(login + ":" + apiKey));
            basicClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", basicAuth);


            jso = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            };
            jso.Converters.Add(new DateTimeConverter());
            jso.Converters.Add(new DateOnlyConverter());
            jso.Converters.Add(new TimeOnlyConverter());
            jso.Converters.Add(new NTimeOnlyConverter());
        }


        private TRes Send<TRes>(string path, bool withToken = false) =>
            Send<TRes, BaseRequest>(path, new(), withToken);


        private TRes Send<TRes, TReq>(string path, TReq req, bool withToken = false)
        {
            HttpResponseMessage res;
            if (withToken)
            {
                if (DateTime.Now.Ticks > expiresIn)
                    Auth();

                res = bearerClient
                    .PostAsJsonAsync(path, req, jso)
                    .Result;
            }
            else
            {
                res = basicClient
                    .PostAsJsonAsync(path, req, jso)
                    .Result;
            }

            return res
                .Content
                .ReadFromJsonAsync<TRes>(jso)
                .Result;
        }


        /// <summary>
        /// Создание токена для методов получения приватной информации
        /// </summary>
        private void Auth()
        {
            var auth = Send<AuthResponse>("/api/v1/auth/createtokentoaccessprivatedata/");
            bearerClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(auth.TokenType, auth.AccessToken);
            expiresIn = DateTime.Now.AddDays(7).Ticks;
        }


        /// <summary>
        /// Данные профиля пользователя.
        /// </summary>
        public ProfileDataResponse GetProfile() =>
            Send<ProfileDataResponse>("/api/v1/auth/profiledata/");


        /// <summary>
        /// Список всех филиалов и городов.
        /// </summary>
        public BranchesResponse GetAllBranches() =>
            Send<BranchesResponse>("/api/v1/branches/all/");


        /// <summary>
        /// Расчет стоимости и сроков перевозки.
        /// </summary>
        public CalculationResponse Calculation(CalculationRequest request) =>
            Send<CalculationResponse, CalculationRequest>("/api/v1/calculator/calculateprice/", request);


        /// <summary>
        /// Метод возвращает ближайшие даты и интервалы времени на забор/доставку груза от даты запроса.
        /// </summary>
        public List<DeliveryTimeSlot> GetDeliveryTimeSlots(DeliveryTimeSlotRequest request) =>
            Send<List<DeliveryTimeSlot>, DeliveryTimeSlotRequest>("/api/v1/calculator/checkdeliverydate/", request);
    }
}
