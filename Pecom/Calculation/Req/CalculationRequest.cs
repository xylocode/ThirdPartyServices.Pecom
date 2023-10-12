using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Enums;
using XyloCode.ThirdPartyServices.Pecom.Models;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Req
{
    public class CalculationRequest
    {
        /// <summary>
        /// Код валюты. Необязательно. По умолчанию 643 - российский рубль.
        /// </summary>
        [JsonPropertyName("currencyCode")]
        public string CurrencyCode { get; set; }


        /// <summary>
        /// Идентификатор склада отправителя.
        /// </summary>
        [JsonPropertyName("senderWarehouseId")]
        public Guid? SenderWarehouseId { get; set; }


        /// <summary>
        /// Идентификатор склада получателя.
        /// </summary>
        [JsonPropertyName("receiverWarehouseId")]
        public Guid? ReceiverWarehouseId { get; set; }


        /// <summary>
        /// Растентовка отправителя.
        /// </summary>
        [JsonPropertyName("isOpenCarSender")]
        public bool? IsOpenCarSender { get; set; }


        /// <summary>
        /// Необходим забор день в день.
        /// </summary>
        [JsonPropertyName("isDayByDay")]
        public bool? IsDayByDay { get; set; }


        /// <summary>
        /// Растентовка получателя.
        /// </summary>
        [JsonPropertyName("isOpenCarReceiver")]
        public bool? IsOpenCarReceiver { get; set; }


        /// <summary>
        /// Признак гипермаркета.
        /// </summary>
        [JsonPropertyName("isHyperMarket")]
        public bool? IsHyperMarket { get; set; }


        /// <summary>
        /// Дата и время планируемой передачи груза в ПЭК:
        /// при заказанном заборе - дата и время начала интервала забора груза (не позднее 4-х часов до окончания работы филиала);
        /// при самопривозе - дата и время плановой сдачи груза на склад ПЭК.
        /// </summary>
        [JsonPropertyName("plannedDateTime")]
        public DateTime PlannedDateTime { get; set; }


        /// <summary>
        /// Страхование.
        /// </summary>
        [JsonPropertyName("isInsurance")]
        public bool? IsInsurance { get; set; }


        /// <summary>
        /// Стоимость груза (сумма, на которую будет застрахован груз), руб.
        /// </summary>
        [JsonPropertyName("isInsurancePrice")]
        public decimal? InsurancePrice { get; set; }


        /// <summary>
        /// Нужен забор.
        /// </summary>
        [JsonPropertyName("isPickUp")]
        public bool? IsPickUp { get; set; }


        /// <summary>
        /// Нужна доставка.
        /// </summary>
        [JsonPropertyName("isDelivery")]
        public bool? IsDelivery { get; set; }


        /// <summary>
        /// Возврат документов.
        /// </summary>
        [JsonPropertyName("needReturnDocuments")]
        public bool? NeedReturnDocuments { get; set; }


        /// <summary>
        /// Организация перевозки сопроводительных документов.
        /// </summary>
        [JsonPropertyName("needArrangeTransportationDocuments")]
        public bool? NeedArrangeTransportationDocuments { get; set; }


        /// <summary>
        /// Массив продуктов/тарифов для расчета. Обязательно.
        /// В настоящее время допускается передача ОДНОГО Продукта/тарифа на расчет.
        /// </summary>
        [JsonPropertyName("transportingTypes")]
        public List<ProductType> TransportingTypes { get; set; }


        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete]
        [JsonPropertyName("senderDistanceType")]
        public int? SenderDistanceType { get; set; }


        /// <summary>
        /// В актуальной версии протокола не используется.
        /// </summary>
        [Obsolete]
        [JsonPropertyName("receiverDistanceType")]
        public int? ReceiverDistanceType { get; set; }


        /// <summary>
        /// Погрузочно-разгрузочные работы при заборе.
        /// </summary>
        [JsonPropertyName("pickupServices")]
        public LoadingServices PickupServices { get; set; }


        /// <summary>
        /// Погрузочно-разгрузочные работы при доставке
        /// </summary>
        [JsonPropertyName("deliveryServices")]
        public LoadingServices DeliveryServices { get; set; }


        /// <summary>
        /// Обязательный параметр для расчёта забора груза.
        /// </summary>
        [JsonPropertyName("pickup")]
        public Point Pickup { get; set; }


        /// <summary>
        /// Обязательный параметр для расчёта доставки груза.
        /// </summary>
        [JsonPropertyName("delivery")]
        public Point Delivery { get; set; }


        /// <summary>
        /// Данные контрагента для расчета с учетом спецусловий.
        /// </summary>
        [JsonPropertyName("counterpart")]
        public Counterpart Counterpart { get; set; }


        /// <summary>
        /// Данные о грузе/грузоместах груза.
        /// </summary>
        [JsonPropertyName("cargos")]
        public List<Cargo> Cargos { get; set; }

    }
}
