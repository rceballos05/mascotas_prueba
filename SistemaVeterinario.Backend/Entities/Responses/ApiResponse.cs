using System.Text.Json.Serialization;

namespace SistemaVeterinario.Backend.Entities.Responses;

public class ApiResponse<T>
{
    [JsonPropertyName("statusCode")]
    public int StatusCode { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("items")]
    public T? Items { get; set; }

    [JsonIgnore]
    public bool IsSuccess => StatusCode is >= 200 and < 300;
}
