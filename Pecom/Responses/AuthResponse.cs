using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Responses
{
    public class AuthResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public DateTime? ExpiresIn { get; set; }
    }
}
