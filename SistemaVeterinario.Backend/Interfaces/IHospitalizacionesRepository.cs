using SistemaVeterinario.Backend.Entities.Dtos;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IHospitalizacionesRepository
    {
        Task<List<HospitalizacionesDto>> GetHospitalizaciones(string token, string prefijo, string id);
    }
}
