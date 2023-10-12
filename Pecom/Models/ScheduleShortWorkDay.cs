using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Сокращенный режим работы.
    /// </summary>
    public class ScheduleShortWorkDay
    {
        /// <summary>
        /// Дата сокращённого дня.
        /// </summary>
        [JsonPropertyName("date")]
        public DateOnly Date { get; set; }

        /// <summary>
        /// Время работы сокращённого дня.
        /// </summary>
        [JsonPropertyName("workTime")]
        public WorkTime WorkTime { get; set; }

        /// <summary>
        /// Обеденный перерыв.
        /// </summary>
        [JsonPropertyName("breakTime")]
        public string BreakTime { get; set; }
    }
}
