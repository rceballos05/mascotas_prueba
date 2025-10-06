using SistemaVeterinario.Backend.Entities.Dtos;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IRecetasRepository
    {
        Task<List<RecetasDto>> GetRecetas(string token, string prefijo, string rut,string id);
    }
}
