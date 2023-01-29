using System.Text.Json.Serialization;

namespace AuthApi.Models
{
    public class ApiRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
