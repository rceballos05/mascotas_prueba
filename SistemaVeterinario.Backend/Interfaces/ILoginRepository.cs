using SistemaVeterinario.Backend.Entities.Requests;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface ILoginRepository
    {
        Task<dynamic> IniciarSesion(LoginRequest request);
    }
}
