using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Models;

namespace XyloCode.ThirdPartyServices.Pecom.Responses
{
    public class BaseResponse
    {
        [JsonPropertyName("error")]
        public Error Error { get; set; }
    }
}
