using System.Net.Http.Json;
using Microsoft.Extensions.Logging;
using SistemaVeterinario.Backend.Statics;
using SistemaVeterinario.Web.Services.Contracts;

namespace SistemaVeterinario.Web.Services;

public sealed class ArchivosService
{
    private readonly IHttpClientFactory httpClientFactory;
    private readonly ILogger<ArchivosService> logger;

    public ArchivosService(IHttpClientFactory httpClientFactory, ILogger<ArchivosService> logger)
    {
        this.httpClientFactory = httpClientFactory;
        this.logger = logger;
    }

    public Task<FileResourceResponse?> CrearCarpetaClienteAsync(string clienteId, CancellationToken cancellationToken = default)
    {
        return CrearRecursoAsync(clienteId, new CreateFileResourceRequest(), cancellationToken);
    }

    public Task<FileResourceResponse?> CrearCarpetaMascotaAsync(string clienteId, string mascotaId, CancellationToken cancellationToken = default)
    {
        return CrearRecursoAsync(clienteId, new CreateFileResourceRequest { MascotaId = mascotaId }, cancellationToken);
    }

    private async Task<FileResourceResponse?> CrearRecursoAsync(string clienteId, CreateFileResourceRequest request, CancellationToken cancellationToken)
    {
        var client = httpClientFactory.CreateClient(HttpClientNames.Api);
        using var response = await client.PostAsJsonAsync($"api/archivos/{clienteId}", request, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            var detalle = await response.Content.ReadAsStringAsync(cancellationToken);
            logger.LogError("No se pudo crear el recurso de archivos para el cliente {ClienteId}. StatusCode: {StatusCode}. Detalle: {Detalle}", clienteId, response.StatusCode, detalle);
            throw new HttpRequestException($"Error al crear recurso de archivos ({response.StatusCode}). {detalle}");
        }

        return await response.Content.ReadFromJsonAsync<FileResourceResponse>(cancellationToken: cancellationToken);
    }
}
