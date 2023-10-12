using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Филиал
    /// </summary>
    public class Branch
    {
        /// <summary>
        /// Идентификатор филиала.
        /// НЕ ИСПОЛЬЗОВАТЬ в методах расчёта стоимости и подачи заявок.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }


        /// <summary>
        /// Буквенный уникальный код филиала.
        /// </summary>
        [JsonPropertyName("branchCode")]
        public string BranchCode { get; set; }


        /// <summary>
        /// Наименование филиала.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }


        /// <summary>
        /// Адрес основного отделения филиала.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }


        /// <summary>
        /// Почтовый индекс основного отделения филиала.
        /// </summary>
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }


        /// <summary>
        /// Координаты GPS основного отделения филиала.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public string Coordinates { get; set; }


        /// <summary>
        /// Код филиала.
        /// В актуальной версии протокола не используется.
        /// </summary>
        [JsonPropertyName("bitrixId")]
        public string BitrixId { get; set; }

        /// <summary>
        /// Часовой пояс основного отделения филиала.
        /// </summary>
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }


        /// <summary>
        /// Страна.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }


        /// <summary>
        /// Список городов филиала.
        /// </summary>
        [JsonPropertyName("cities")]
        public List<City> Cities { get; set; }


        /// <summary>
        /// Список отделений.
        /// </summary>
        [JsonPropertyName("divisions")]
        public List<Division> Divisions { get; set; }
    }
}
