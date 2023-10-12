using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Доступные операции в отделении.
    /// </summary>
    public class KindsOfTransportation
    {
        /// <summary>
        /// Наименование тарифа/продукта.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }


        /// <summary>
        /// Идентификатор тарифа/продукта.
        /// </summary>
        [JsonPropertyName("type")]
        public int? Type { get; set; }


        /// <summary>
        /// Доступные операции в отделении для данного тарифа/продукта.
        /// </summary>
        [JsonPropertyName("operations")]
        public List<string> Operations { get; set; }
    }

}
