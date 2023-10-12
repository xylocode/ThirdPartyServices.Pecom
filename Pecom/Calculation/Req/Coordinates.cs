using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Calculation.Req
{
    public class Coordinates
    {
        /// <summary>
        /// Широта.
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Долгота.
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}