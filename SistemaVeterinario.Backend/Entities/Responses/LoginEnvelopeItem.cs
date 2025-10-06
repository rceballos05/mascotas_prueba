using System.Text.Json.Serialization;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Entities.Responses;

public class LoginEnvelopeItem
{
    [JsonPropertyName("login")]
    public AdmUser? Login { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; } = string.Empty;

    [JsonPropertyName("empresas")]
    public List<EmpresasDto>? Empresas { get; set; }
}
