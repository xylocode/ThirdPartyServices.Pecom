using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Res
{
    /// <summary>
    /// Данные по услугам за вид перевозки.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Услуга.
        /// </summary>
        [JsonPropertyName("serviceType")]
        public string ServiceType { get; set; }


        /// <summary>
        /// Город отправитель.
        /// </summary>
        [JsonPropertyName("senderCity")]
        public string SenderCity { get; set; }


        /// <summary>
        /// Сумма за услугу, руб.
        /// </summary>
        [JsonPropertyName("cost")]
        public decimal? Cost { get; set; }

        /// <summary>
        /// Расшифровка услуги.
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }


        /// <summary>
        /// Вложенные услуги.
        /// </summary>
        [JsonPropertyName("services")]
        public List<Service> Services { get; set; }
    }
}