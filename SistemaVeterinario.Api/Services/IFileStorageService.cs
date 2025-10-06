using SistemaVeterinario.Api.Contracts.Requests;
using SistemaVeterinario.Api.Contracts.Responses;

namespace SistemaVeterinario.Api.Services;

public interface IFileStorageService
{
    Task<FileResourceResponse> EnsureResourceAsync(string clienteId, CreateFileResourceRequest request, CancellationToken cancellationToken);
}
