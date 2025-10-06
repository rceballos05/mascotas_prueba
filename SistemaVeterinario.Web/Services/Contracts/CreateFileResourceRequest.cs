using System.ComponentModel.DataAnnotations;

namespace SistemaVeterinario.Web.Services.Contracts;

public sealed class CreateFileResourceRequest
{
    [MaxLength(64)]
    public string? MascotaId { get; set; }
}
