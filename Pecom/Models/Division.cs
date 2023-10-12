using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Отделение
    /// </summary>
    public class Division
    {
        /// <summary>
        /// Идентификатор отделения.
        /// НЕ ИСПОЛЬЗОВАТЬ в методах расчёта стоимости и подачи заявок.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }


        /// <summary>
        /// Идентификатор города, которому принадлежит отделение.
        /// </summary>
        [JsonPropertyName("cityId")]
        public Guid? CityId { get; set; }


        /// <summary>
        /// Наименование отделения.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Приоритет автоматической подстановки отделений на стороне ПЭК (используется, если в запросах не указано конкретное отделение).
        /// </summary>
        [JsonPropertyName("divisionPriority")]
        public int? DivisionPriority { get; set; }


        /// <summary>
        /// Значение true, если осуществляется только ПРИЁМ груза.
        /// </summary>
        [JsonPropertyName("isAcceptanceOnly")]
        public bool? IsAcceptanceOnly { get; set; }


        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete]
        [JsonPropertyName("isPartialDistributionAllowed")]
        public bool? IsPartialDistributionAllowed { get; set; }


        /// <summary>
        /// ID типа отделения.
        /// </summary>
        [JsonPropertyName("departmentTypeId")]
        public int? DepartmentTypeId { get; set; }


        /// <summary>
        /// Наименование типа отделения.
        /// </summary>
        [JsonPropertyName("departmentType")]
        public string DepartmentType { get; set; }


        /// <summary>
        /// Информация о складах.
        /// </summary>
        [JsonPropertyName("warehouses")]
        public List<Warehouse> Warehouses { get; set; }


        /// <summary>
        /// Доступные операции в отделении.
        /// ОБЯЗАТЕЛЬНО ПРОВЕРЯЙТЕ ДОСТУПНОСТЬ ОПЕРАЦИЙ ПРИ ВЫБОРЕ ОТДЕЛЕНИЯ!
        /// </summary>
        [JsonPropertyName("kindsOfTransportation")]
        public List<KindsOfTransportation> KindsOfTransportation { get; set; }
    }
}
