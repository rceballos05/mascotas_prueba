using System.IO;

namespace SistemaVeterinario.Api.Options;

public sealed class FileStorageOptions
{
    public const string SectionName = "FileStorage";

    public string BasePath { get; set; } = Path.Combine(AppContext.BaseDirectory, "uploads");
}
