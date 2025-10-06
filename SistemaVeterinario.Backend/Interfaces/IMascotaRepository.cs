using SistemaVeterinario.Backend.Entities.Requests;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IMascotaRepository
    {
        Task<dynamic> GetMascota(string token, string prefijo, string id);
        Task<dynamic> GetNumeroMascota(string token, string prefijo);
        Task<dynamic> GetMascotaRutCliente(string token, string prefijo, string rut);
        Task<dynamic> PostMascota(string token, string prefijo, MascotaDtoRequest mascota);
        Task<dynamic> PutMascota(string token, string prefijo, MascotaDtoRequest mascota);
        Task<dynamic> DeleteMascota(string token, string prefijo, string id);
    }
}
