using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Req
{
    /// <summary>
    /// Погрузочно-разгрузочные работы.
    /// </summary>
    public class LoadingServices
    {
        /// <summary>
        /// Расчитывать ПРР.
        /// </summary>
        [JsonPropertyName("isLoading")]
        public bool? IsLoading { get; set; }

        /// <summary>
        /// Поднять/спустить на этаж.
        /// </summary>
        [JsonPropertyName("floor")]
        public int? Floor { get; set; }


        /// <summary>
        /// Перенести груз (в метрах).
        /// </summary>
        [JsonPropertyName("carryingDistance")]
        public int? CarryingDistance { get; set; }


        /// <summary>
        /// Подъем на лифте.
        /// </summary>
        [JsonPropertyName("isElevator")]
        public bool? IsElevator { get; set; }
    }
}