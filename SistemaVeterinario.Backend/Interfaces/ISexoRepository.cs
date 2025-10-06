namespace SistemaVeterinario.Backend.Interfaces
{
    public interface ISexoRepository
    {
        Task<dynamic> GetSexos(string token, string prefijo);
    }
}
