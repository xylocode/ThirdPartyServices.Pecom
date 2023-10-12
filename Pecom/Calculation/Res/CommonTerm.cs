using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Enums;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Res
{
    /// <summary>
    /// Общие данных по срокам перевозок.
    /// </summary>
    public class CommonTerm
    {
        /// <summary>
        /// Вид перевозки.
        /// </summary>
        [JsonPropertyName("transportingType")]
        public ProductType? TransportingType { get; set; }


        /// <summary>
        /// Филиал-отправитель.
        /// </summary>
        [JsonPropertyName("branchSender")]
        public string BranchSender { get; set; }


        /// <summary>
        /// Филиал-получатель.
        /// </summary>
        [JsonPropertyName("branchReceiver")]
        public string BranchReceiver { get; set; }


        /// <summary>
        /// Дни льготной доставки.
        /// </summary>
        [JsonPropertyName("discountedDeliveryWeekDays")]
        public List<DayOfWeek> DiscountedDeliveryWeekDays { get; set; }


        /// <summary>
        /// Ориентировочные сроки перевозки, в сутках.
        /// </summary>
        [JsonPropertyName("transporting")]
        public List<string> Transporting { get; set; }

        /// <summary>
        /// Срок перевозки с забором, в сутках.
        /// </summary>
        [JsonPropertyName("transportingWithDelivery")]
        public List<string> TransportingWithDelivery { get; set; }


        /// <summary>
        /// Срок перевозки с забором, в сутках.
        /// </summary>
        [JsonPropertyName("transportingWithPickup")]
        public string TransportingWithPickup { get; set; }

        /// <summary>
        /// Срок перевозки с забором и доставкой, в сутках.
        /// </summary>
        [JsonPropertyName("transportingWithDeliveryWithPickup")]
        public string TransportingWithDeliveryWithPickup { get; set; }


        /// <summary>
        /// Указываются дни недели отправки груза из филиала отправления в филиал получения.
        /// </summary>
        [JsonPropertyName("senderShippingDays")]
        public List<DayOfWeek> SenderShippingDays { get; set; }
    }

}