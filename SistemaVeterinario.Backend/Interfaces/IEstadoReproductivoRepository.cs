namespace SistemaVeterinario.Backend.Repositories
{
    public interface IEstadoReproductivoRepository
    {
        Task<dynamic> GetEstadosReproductivos(string token, string prefijo);
    }
}
