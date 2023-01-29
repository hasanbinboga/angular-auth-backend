using System.Text.Json.Serialization;

namespace AuthApi.Models
{
    public class ApiResult<T>
    {
        [JsonPropertyName("data")]
        public T? Data { get; set; }
        [JsonPropertyName("status")]
        public ApiStatus Status { get; set; }
        [JsonPropertyName("error")]
        public string? Error { get; set; }
    }
}
