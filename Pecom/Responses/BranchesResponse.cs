using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.Pecom.Models;

namespace XyloCode.ThirdPartyServices.Pecom.Responses
{
    public class BranchesResponse : BaseResponse
    {
        [JsonPropertyName("branches")]
        public List<Branch> Branches { get; set; }
    }
}
