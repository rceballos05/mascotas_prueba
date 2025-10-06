using SistemaVeterinario.Backend.Entities.Dtos;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IControlesRepository
    {
        Task<List<ControlDto>> ControlesMascota(string token, string prefijo, string idMascota);
        Task<ControlDto> UltimoControlMascota(string token, string prefijo, string idMascota);
        Task<dynamic> ControlesTipo(string token, string prefijo, string idTipo);
    }
}
