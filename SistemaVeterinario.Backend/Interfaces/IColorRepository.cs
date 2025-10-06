using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IColorRepository
    {
        Task<List<MedColor>> GetColores(string token, string prefijo);
        Task<dynamic> GetColor(string token, string prefijo, string id);
        Task<dynamic> GetNumeroColor(string token, string prefijo);
        Task<dynamic> PostColor(string token, string prefijo, MedColor dto);
        Task<dynamic> PutColor(string token, string prefijo, MedColor dto);
        Task<dynamic> DeleteColor(string token, string prefijo, string id);
    }
}
