using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Repositories
{
    public interface IPropietarioRepository 
    {
        Task<dynamic> GetPropietario(string token,string rut, string prefijo);
        Task<dynamic> PostPropietario(string token,ClienteDto request, string prefijo);
    }
}
