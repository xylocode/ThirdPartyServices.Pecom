using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Время работы сокращённого дня.
    /// </summary>
    public class WorkTime
    {
        /// <summary>
        /// Начало рабочего дня.
        /// </summary>
        [JsonPropertyName("periodTimeFrom")]
        public TimeOnly? PeriodTimeFrom { get; set; }


        /// <summary>
        /// Конец рабочего дня.
        /// </summary>
        [JsonPropertyName("periodTimeTo")]
        public TimeOnly? PeriodTimeTo { get; set; }
    }
}
