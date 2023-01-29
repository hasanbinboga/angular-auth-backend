using System.Text.Json.Serialization;

namespace AuthApi.Models
{
    public class AuthToken
    {
        [JsonPropertyName("userGroup")]
        public int UserGroup { get; set; }
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
