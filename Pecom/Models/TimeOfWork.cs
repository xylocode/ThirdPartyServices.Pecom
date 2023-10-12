using System;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Helpers;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Время работы отделения.
    /// </summary>
    public class TimeOfWork
    {
        /// <summary>
        /// Начало рабочего дня.
        /// Пустая строка означает время "00:00". 
        /// </summary>
        [JsonPropertyName("workFrom")]
        public TimeOnly? WorkFrom { get; set; }

        /// <summary>
        /// Конец рабочего дня.
        /// </summary>
        [JsonPropertyName("workTo")]
        public TimeOnly? WorkTo { get; set; }


        /// <summary>
        /// Начало обеденного перерыва.
        /// </summary>
        [JsonPropertyName("dinnerFrom")]
        public TimeOnly? DinnerFrom { get; set; }


        /// <summary>
        /// Конец обеденного перерыва.
        /// </summary>
        [JsonPropertyName("dinnerTo")]
        public TimeOnly? DinnerTo { get; set; }


        /// <summary>
        /// День недели (1 - понедельник, 6 - суббота).
        /// </summary>
        [JsonPropertyName("dayOfWeek")]
        [JsonConverter(typeof(JsonStringAsDayOfWeekConverter))]
        public Enums.DayOfWeek? DayOfWeek { get; set; }
    }
}
