namespace SistemaVeterinario.Web.Services.Contracts;

public sealed class FileResourceResponse
{
    public required string ResourceId { get; init; }
    public required string RelativePath { get; init; }
}
