using System.ComponentModel.DataAnnotations;

namespace SistemaVeterinario.Api.Contracts.Requests;

public sealed record CreateFileResourceRequest
{
    [MaxLength(64)]
    public string? MascotaId { get; init; }
}
