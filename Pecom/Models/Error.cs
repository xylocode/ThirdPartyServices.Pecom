using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Models
{
    public class Error
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        //[JsonPropertyName("error")]
        //public object Error { get; set; }

        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }
}
