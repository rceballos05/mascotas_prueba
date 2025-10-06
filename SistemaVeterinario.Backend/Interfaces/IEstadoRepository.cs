namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IEstadoRepository
    {
        Task<dynamic> GetEstados(string token, string prefijo);
        Task<dynamic> GetEstado(string token, string prefijo, string id);
    }
}
