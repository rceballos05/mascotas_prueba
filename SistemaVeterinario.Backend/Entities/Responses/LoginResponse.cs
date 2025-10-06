using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Entities.Responses
{
    public class LoginResponse
    {
        public AdmUser? Login { get; set; }
        public string Token { get; set; } = null!;
        public List<EmpresasDto>? Empresas { get; set; }
    }
}
