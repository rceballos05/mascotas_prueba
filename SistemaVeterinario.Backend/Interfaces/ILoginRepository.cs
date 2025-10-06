using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Entities.Responses;

namespace SistemaVeterinario.Backend.Interfaces;

public interface ILoginRepository
{
    Task<LoginResponse> IniciarSesion(LoginRequest request);
}
