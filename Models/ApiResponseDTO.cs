using System.Text.Json.Serialization;

namespace IdeaCenter1.Models
{
    internal class ApiResponseDTO
    {
        [JsonPropertyName("msg")]

        public string? Msg { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}