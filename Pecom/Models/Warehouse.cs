using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Склад
    /// </summary>
    public class Warehouse
    {
        /// <summary>
        /// Буквенный уникальный код склада.
        /// </summary>
        [JsonPropertyName("warehouseCode")]
        public string WarehouseCode { get; set; }


        /// <summary>
        /// Идентификатор склада.
        /// НЕ ИСПОЛЬЗОВАТЬ в методах расчёта стоимости и подачи заявок!
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }


        /// <summary>
        /// Идентификатор отделения.
        /// НЕ ИСПОЛЬЗОВАТЬ в методах расчёта стоимости и подачи заявок.
        /// </summary>
        [JsonPropertyName("divisionId")]
        public Guid? DivisionId { get; set; }


        /// <summary>
        /// Наименование склада.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Наименование отделения.
        /// </summary>
        [JsonPropertyName("divisionName")]
        public string DivisionName { get; set; }


        /// <summary>
        /// Адрес склада.
        /// Максимально короткий адрес для использования в оповещениях.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }


        /// <summary>
        /// Полный адрес склада.
        /// </summary>
        [JsonPropertyName("addressDivision")]
        public string AddressDivision { get; set; }


        /// <summary>
        /// Подробное описание, как добраться до отделения.
        /// Длина не ограничена.
        /// </summary>
        [JsonPropertyName("pointerDescription")]
        public string PointerDescription { get; set; }


        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete("Для определения доступных операций используйте массив \"kindsOfTransportation\":[] и ограничения по габаритам.")]
        [JsonPropertyName("isAcceptanceOnly")]
        public bool? IsAcceptanceOnly { get; set; }


        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete("Для определения доступных операций используйте массив \"kindsOfTransportation\":[] и ограничения по габаритам.")]
        [JsonPropertyName("isWarehouseGivesFreights")]
        public bool? IsWarehouseGivesFreights { get; set; }


        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete("Для определения доступных операций используйте массив \"kindsOfTransportation\":[] и ограничения по габаритам.")]
        [JsonPropertyName("isWarehouseAcceptsFreights")]
        public bool? IsWarehouseAcceptsFreights { get; set; }


        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete("Для определения доступных операций используйте массив \"kindsOfTransportation\":[] и ограничения по габаритам.")]
        [JsonPropertyName("isRestrictions")]
        public bool? IsRestrictions { get; set; }

        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete("Для определения доступных операций используйте массив \"kindsOfTransportation\":[] и ограничения по габаритам.")]
        [JsonPropertyName("isFreightSurcharge")]
        public bool? IsFreightSurcharge { get; set; }


        [JsonPropertyName("coordinates")]
        public string Coordinates { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude {  get; set; }


        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }


        /// <summary>
        /// Максимально допустимый вес груза, кг.
        /// </summary>
        [JsonPropertyName("maxWeight")]
        public double? MaxWeight { get; set; }


        /// <summary>
        /// Максимально допустимый объем груза, м.куб.
        /// </summary>
        [JsonPropertyName("maxVolume")]
        public double? MaxVolume { get; set; }


        /// <summary>
        /// Максимально допустимый вес грузоместа, кг.
        /// </summary>
        [JsonPropertyName("maxWeightPerPlace")]
        public double? MaxWeightPerPlace { get; set; }


        /// <summary>
        /// Максимальный габарит грузоместа, м. 
        /// </summary>
        [JsonPropertyName("maxDimension")]
        public double? MaxDimension { get; set; }


        /// <summary>
        /// Плановая дата доступности отделения для подачи заявок в связи с закрытием.
        /// </summary>
        [JsonPropertyName("endOfAvailabilityBeforeClosing")]
        public DateTime? EndOfAvailabilityBeforeClosing { get; set; }


        /// <summary>
        /// Дата запрета расчета стоимости по данному отделению в связи с плановым закрытием.
        /// </summary>
        [JsonPropertyName("endOfCostCalculationAvailability")]
        public DateTime? EndOfCostCalculationAvailability { get; set; }


        /// <summary>
        /// Дата прекращения работы отделения.
        /// </summary>
        [JsonPropertyName("departmentClosingDate")]
        public DateTime? DepartmentClosingDate { get; set; }


        // В актуальной версии протокола не используется.
        //[Obsolete]
        //[JsonPropertyName("timeOfWork")]
        //public List<object> TimeOfWork { get; set; }


        /// <summary>
        /// Время работы отделения.
        /// Если нет элемента с конкретным днем недели, значит в этот день отделение не работает.
        /// </summary>
        [JsonPropertyName("divisionTimeOfWork")]
        public List<TimeOfWork> DivisionTimeOfWork { get; set; }


        /// <summary>
        /// Сокращенный режим работы.
        /// </summary>
        [JsonPropertyName("scheduleShortWorkDays")]
        public List<ScheduleShortWorkDay> ScheduleShortWorkDays { get; set; }


        /// <summary>
        /// Выходные и праздничные дни.
        /// </summary>
        [JsonPropertyName("scheduleHolidayDays")]
        public List<DateOnly> ScheduleHolidayDays { get; set; }
    }

}
