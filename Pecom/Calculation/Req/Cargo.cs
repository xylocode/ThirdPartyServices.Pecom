using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Req
{
    /// <summary>
    /// Данные о грузе/грузоместах груза.
    /// </summary>
    public class Cargo
    {
        /// <summary>
        /// Длина груза, м. Необязательно, если передан maxSize.
        /// </summary>
        [JsonPropertyName("length")]
        public double? Length { get; set; }

        /// <summary>
        /// Ширина груза, м. Необязательно, если передан maxSize.
        /// </summary>
        [JsonPropertyName("width")]
        public double? Width { get; set; }


        /// <summary>
        /// Высота груза, м. Необязательно, если передан maxSize.
        /// </summary>
        [JsonPropertyName("height")]
        public double? Height { get; set; }


        /// <summary>
        /// Объем груза, м3. Необязательно, если переданы длина, ширина, высота.
        /// </summary>
        [JsonPropertyName("volume")]
        public double? Volume { get; set; }


        /// <summary>
        /// Максимальный габарит, м.
        /// Необязательно, если переданы длина, ширина, высота (которые имеют приоритет). 
        /// </summary>
        [JsonPropertyName("maxSize")]
        public double? MaxSize { get; set; }


        /// <summary>
        /// Защитная транспортировочная упаковка. Необязательно
        /// </summary>
        [JsonPropertyName("isHP")]
        public bool? IsHP { get; set; }


        /// <summary>
        /// Количество мест для пломбировки - пломб (применяются для небольших мест или сложных грузов). Необязательно.
        /// </summary>
        [JsonPropertyName("sealingPositionsCount")]
        public int? SealingPositionsCount { get; set; }


        /// <summary>
        /// Вес, кг. Обязательно.
        /// </summary>
        [JsonPropertyName("weight")]
        public double? Weight { get; set; }
    }
}