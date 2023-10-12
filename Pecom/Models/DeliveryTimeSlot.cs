using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    public class DeliveryTimeSlot
    {
        /// <summary>
        /// Ближайший день забора/доставки от переданной даты в запросе.
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }


        /// <summary>
        /// В этот день действует льготный тариф на забор/доставку по запрошенному адресу.
        /// </summary>
        [JsonPropertyName("isPreferential")]
        public bool? IsPreferential { get; set; }


        /// <summary>
        /// Минимальные временные интервалы на забор/доставку груза.
        /// </summary>
        [JsonPropertyName("periods")]
        public List<TimeSlot> TimeSlots { get; set; }

    }

    public class TimeSlot
    {
        /// <summary>
        /// Время начала интервала.
        /// </summary>
        [JsonPropertyName("periodTimeFrom")]
        public TimeOnly? PeriodTimeFrom { get; set; }


        /// <summary>
        /// Время окончания интервала.
        /// </summary>
        [JsonPropertyName("periodTimeTo")]
        public TimeOnly? PeriodTimeTo { get; set; }


        /// <summary>
        /// Временной интервал без наценки на забор/доставку в ночное время.
        /// Значение false означает, что будет наценка за ночное время (возможность оказания услуги необходимо уточнять у менеджера).
        /// </summary>
        [JsonPropertyName("isDayLight")]
        public bool? IsDayLight { get; set; }
    }
}
