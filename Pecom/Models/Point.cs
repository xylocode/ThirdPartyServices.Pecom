using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Calculation.Req;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    /// <summary>
    /// Местополежение забора/доставки груза.
    /// </summary>
    public class Point
    {
        public Point() { }

        public Point(string address) { Address = address; }
        public Point(double latitude, double longitude)
        {
            Coordinates = new Coordinates { Latitude = latitude, Longitude = longitude };
        }

        /// <summary>
        /// Адрес забора/доставки груза.
        /// Необязательный параметр, если переданы координаты.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Координаты адреса забора/доставки (используется для точности вычислений).
        /// Если переданы координаты, то значение в поле address игнорируется. Необязательный параметр.
        /// </summary>
        [JsonPropertyName("coordinates")]
        public Coordinates Coordinates { get; set; }
    }
}