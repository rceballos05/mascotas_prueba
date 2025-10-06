using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IEspecialistaRepository
    {
        Task<List<SeguUsuarios>> GetEspecialistas(string token, string prefijo, string local);
        Task<List<SeguUsuarios>> GetMedicos(string token, string prefijo, string local);
        Task<SeguUsuarios> GetEspecialistaByCode(string token, string prefijo, string local, int codigo);
    }
}
