using SistemaVeterinario.Backend.Entities.Dtos;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IEspecieRepository
    {
        Task<List<EspecieDto>> GetEspecies(string token, string prefijo);
        Task<dynamic> GetEspecie(string token, string prefijo, string id);
        Task<dynamic> GetNumeroEspecie(string token, string prefijo);
        Task<dynamic> PostEspecie(string token, string prefijo, EspecieDto dto);
        Task<dynamic> PutEspecie(string token, string prefijo, EspecieDto dto);
        Task<dynamic> DeleteEspecie(string token, string prefijo, string id);
    }
}
