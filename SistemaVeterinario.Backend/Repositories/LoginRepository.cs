using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Entities.Responses;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories;

public class LoginRepository : ILoginRepository
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private readonly HttpClient httpClient;
    private readonly ILogger<LoginRepository> logger;

    public LoginRepository(HttpClient httpClient, ILogger<LoginRepository> logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<LoginResponse> IniciarSesion(LoginRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        using var response = await httpClient.PostAsJsonAsync("api/sales-administrator/login", request);
        var payload = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            logger.LogWarning("Error al iniciar sesión. Código {StatusCode}. Respuesta: {Payload}", response.StatusCode, payload);
            throw new HttpRequestException($"No se pudo iniciar sesión (código {(int)response.StatusCode}). {payload}");
        }

        var envelope = JsonSerializer.Deserialize<ApiResponse<List<LoginEnvelopeItem>>>(payload, SerializerOptions);
        if (envelope is null)
        {
            throw new InvalidOperationException("No se pudo deserializar la respuesta de autenticación.");
        }

        if (!envelope.IsSuccess || envelope.Items is null || envelope.Items.Count == 0)
        {
            var message = envelope.Message ?? "La autenticación no devolvió resultados";
            throw new InvalidOperationException(message);
        }

        var item = envelope.Items[0];
        if (item.Login is null || string.IsNullOrWhiteSpace(item.Token))
        {
            throw new InvalidOperationException("La respuesta de autenticación está incompleta.");
        }

        return new LoginResponse
        {
            Login = item.Login,
            Token = item.Token,
            Empresas = item.Empresas ?? new List<Entities.Dtos.EmpresasDto>()
        };
    }
}
