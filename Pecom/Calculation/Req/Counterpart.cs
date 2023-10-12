using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Enums;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Req
{
    /// <summary>
    /// Данные контрагента для расчета с учетом спецусловий.
    /// </summary>
    public class Counterpart
    {
        /// <summary>
        /// ИНН контрагента.
        /// </summary>
        [JsonPropertyName("inn")]
        public string Inn { get; set; }


        /// <summary>
        /// КПП контрагента, поле необязательно.
        /// </summary>
        [JsonPropertyName("kpp")]
        public string Kpp { get; set; }


        /// <summary>
        /// Роль заказчика перевозки (кто производит расчет: 1 - отправитель, 2 - получатель, 3 - плательщик)
        /// </summary>
        [JsonPropertyName("whoMakesCalculation")]
        public List<RoleType> WhoMakesCalculation { get; set; }
    }
}