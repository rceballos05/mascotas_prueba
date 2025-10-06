using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.NavigationData
{
    public class UserNavgationData
    {
        public AdmUser? Login { get; set; }
        public string Token { get; set; } = null!;
        public List<EmpresasDto>? Empresas { get; set; }
    }
}
