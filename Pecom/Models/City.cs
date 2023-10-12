using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Enums;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Город филиала
    /// </summary>
    public class City
    {
        /// <summary>
        /// Наименование города.
        /// Наименование из справочника ПЭК.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }


        /// <summary>
        /// Код города.
        /// В актуальной версии протокола не используется.
        /// </summary>
        [JsonPropertyName("bitrixId")]
        public string BitrixId { get; set; }


        /// <summary>
        /// Идентификатор города.
        /// НЕ ИСПОЛЬЗОВАТЬ в методах расчёта стоимости и подачи заявок.
        /// </summary>
        [JsonPropertyName("cityId")]
        public Guid CityId { get; set; }

        /// <summary>
        /// Тип населенного пункта.
        /// </summary>
        [JsonPropertyName("cityStatus")]
        public CityType? CityStatus { get; set; }


        /// <summary>
        /// Список отделений
        /// </summary>
        [JsonPropertyName("divisions")]
        public List<Guid> Divisions { get; set; }
    }
}
