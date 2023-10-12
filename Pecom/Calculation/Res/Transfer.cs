using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Enums;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Res
{
    /// <summary>
    /// Перевозка
    /// </summary>
    public class Transfer
    {
        /// <summary>
        /// Вид перевозки.
        /// </summary>
        [JsonPropertyName("transportingType")]
        public ProductType? TransportingType { get; set; }


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
        /// Общая сумма по виду перевозки, руб.
        /// </summary>
        [JsonPropertyName("costTotal")]
        public decimal? CostTotal { get; set; }


        /// <summary>
        /// Данные по услугам за вид перевозки.
        /// Каждый эалемент массива и подмассива - отдельная услуга, со своей стиоимостью.
        /// </summary>
        [JsonPropertyName("services")]
        public List<Service> Services { get; set; }
    }
}