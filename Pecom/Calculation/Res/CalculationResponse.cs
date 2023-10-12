using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Responses;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Res
{
    /// <summary>
    /// Результат расчёта.
    /// </summary>
    public class CalculationResponse : BaseResponse
    {
        /// <summary>
        /// Признак ошибок при расчетах.
        /// </summary>
        [JsonPropertyName("hasError")]
        public bool? HasError { get; set; }


        /// <summary>
        /// Текст ошибки.
        /// </summary>
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }


        /// <summary>
        /// Код валюты, в которой выполнен расчет стоимости.
        /// </summary>
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }


        /// <summary>
        /// Результаты расчетов по видам перевозок.
        /// </summary>
        [JsonPropertyName("transfers")]
        public List<Transfer> Transfers { get; set; }


        /// <summary>
        /// Массив данных по времени приемки груза.
        /// </summary>
        [JsonPropertyName("transportingTimes")]
        public List<DateTime> TransportingTimes { get; set; }


        /// <summary>
        /// Общие данных по срокам перевозок.
        /// </summary>
        [JsonPropertyName("commonTerms")]
        public List<CommonTerm> CommonTerms { get; set; }

    }
}
