using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.Pecom.Responses
{
    /// <summary>
    /// Профиль пользователя
    /// </summary>
    public class ProfileDataResponse : BaseResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("inn")]
        public string Inn { get; set; }

        [JsonPropertyName("kpp")]
        public string Kpp { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
