using SistemaVeterinario.Backend.Entities.Requests;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IAyudaRepository
    {
        Task<dynamic> AyudaPropietario(string token,string prefijo, string palabra);
        Task<dynamic> AyudaPaciente(string token, string prefijo, AyudaPacienteDtoRequest request);
    }
}
