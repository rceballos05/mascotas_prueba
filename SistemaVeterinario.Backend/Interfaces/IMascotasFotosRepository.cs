using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IMascotasFotosRepository
    {
        Task<dynamic> IdFoto(string token, string prefijo);
        Task<MedMascotaFotos> GetFotoMascota(string token, string prefijo, string id);
        Task<dynamic> PostFotoMascota(string token, string prefijo, MedMascotaFotos md);
        Task<dynamic> PutFotoMascota(string token, string prefijo, MedMascotaFotos md);
    }
}
