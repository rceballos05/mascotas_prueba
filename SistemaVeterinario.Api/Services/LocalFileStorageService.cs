using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SistemaVeterinario.Api.Contracts.Requests;
using SistemaVeterinario.Api.Contracts.Responses;
using SistemaVeterinario.Api.Options;

namespace SistemaVeterinario.Api.Services;

public sealed class LocalFileStorageService : IFileStorageService
{
    private static readonly Regex UnsafeSegment = new("[^a-zA-Z0-9_-]", RegexOptions.Compiled | RegexOptions.CultureInvariant);
    private readonly FileStorageOptions options;
    private readonly ILogger<LocalFileStorageService> logger;

    public LocalFileStorageService(IOptions<FileStorageOptions> options, ILogger<LocalFileStorageService> logger)
    {
        this.options = options.Value;
        this.logger = logger;
    }

    public Task<FileResourceResponse> EnsureResourceAsync(string clienteId, CreateFileResourceRequest request, CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(clienteId);
        ArgumentNullException.ThrowIfNull(request);

        var sanitizedClienteId = Sanitize(clienteId);
        if (string.IsNullOrEmpty(sanitizedClienteId))
        {
            throw new ArgumentException("El identificador del cliente es inválido", nameof(clienteId));
        }

        var baseDirectory = EnsureBaseDirectory();
        var clienteDirectory = Path.Combine(baseDirectory, $"cliente_{sanitizedClienteId}");
        Directory.CreateDirectory(clienteDirectory);

        string relativePath;
        if (!string.IsNullOrWhiteSpace(request.MascotaId))
        {
            var sanitizedMascotaId = Sanitize(request.MascotaId);
            if (string.IsNullOrEmpty(sanitizedMascotaId))
            {
                throw new ArgumentException("El identificador de la mascota es inválido", nameof(request.MascotaId));
            }

            var mascotaDirectory = Path.Combine(clienteDirectory, $"mascota_{sanitizedMascotaId}");
            Directory.CreateDirectory(mascotaDirectory);
            relativePath = Path.GetRelativePath(baseDirectory, mascotaDirectory);
        }
        else
        {
            relativePath = Path.GetRelativePath(baseDirectory, clienteDirectory);
        }

        var response = new FileResourceResponse(Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture), relativePath.Replace('\', '/'));
        logger.LogInformation("Se aseguró el recurso de archivos {RelativePath} para el cliente {ClienteId}", relativePath, sanitizedClienteId);
        return Task.FromResult(response);
    }

    private string EnsureBaseDirectory()
    {
        var basePath = options.BasePath;
        if (string.IsNullOrWhiteSpace(basePath))
        {
            throw new InvalidOperationException("La ruta base de almacenamiento no está configurada.");
        }

        Directory.CreateDirectory(basePath);
        return basePath;
    }

    private static string Sanitize(string? segment)
    {
        if (string.IsNullOrWhiteSpace(segment))
        {
            return string.Empty;
        }

        return UnsafeSegment.Replace(segment, string.Empty);
    }
}
