using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IAuditoriaRepository
    {
        Task<dynamic> PostAuditoria(string token, string prefijo, ControlUsuarioClinica dto);
    }
}
