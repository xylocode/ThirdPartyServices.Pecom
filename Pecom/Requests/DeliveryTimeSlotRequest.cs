using System;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Models;

namespace XyloCode.ThirdPartyServices.Pecom.Requests
{
    public class DeliveryTimeSlotRequest : Point
    {
        /// <summary>
        /// Дата запроса, необязательный параметр.
        /// Если не заполнен считается от текущей даты.
        /// </summary>
        [JsonPropertyName("requestDateTime")]
        public DateOnly? Date { get; set; }

        
        /// <summary>
        /// Количество дней для расчета забора/доставки от даты запроса, расчет не более 5 дней.
        /// Если не заполнен значение по умолчанию равно, необязательный параметр.
        /// </summary>
        [JsonPropertyName("calculateDays")]
        public byte? CalculateDays { get; set; }
    }
}
