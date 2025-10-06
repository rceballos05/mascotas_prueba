namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IComunasRepository
    {
        Task<dynamic> GetComunas(string token, string prefijo);
    }
}
