using SistemaVeterinario.Backend.Entities.Dtos;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IRazaRepository
    {
        Task<List<RazaDto>> GetRazas(string token, string prefijo, string idEspecie);
        Task<dynamic> GetRaza(string token, string prefijo, string idEspecie, string idRaza);
        Task<dynamic> PutRaza(string token, string prefijo, string idEspecie, RazaDto dto);
        Task<dynamic> PostRaza(string token, string prefijo, string idEspecie, RazaDto dto);
        Task<dynamic> DeleteRaza(string token, string prefijo, string idEspecie, string idRaza);
        Task<dynamic> NumeroRaza(string token, string prefijo);
    }
}
