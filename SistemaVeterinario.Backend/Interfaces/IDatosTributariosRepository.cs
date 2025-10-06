using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IDatosTributariosRepository
    {
        Task<MaeEmpresasDatos> GetDatos(string token, string prefijo, string local);
    }
}
