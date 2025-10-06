using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Requests;
using System.Runtime.CompilerServices;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IConsultasRepository
    {
        Task<List<ConsultasDto>> ConsultasMascota(string token, string prefijo, string idMascota);
        Task<dynamic> ConsultasTipo(string token, string prefijo, string idTipo);
        Task<dynamic> NumeroConsulta(string token, string prefijo);
        Task<List<TipoConsulta>> Consultas(string token, string prefijo);
        Task<dynamic> LocacionesConsultas(string token, string prefijo);
        Task<dynamic> IngresarConsulta(string token, string prefijo,IngresoConsultaDto dto);
        Task<dynamic> DetalleConsulta(string token, string prefijo, string idconsulta);
        Task<dynamic> UpdateConsulta(string token, string prefijo, string idconsulta, IngresoConsultaDto dto);
        Task<dynamic> NumeroConsultaTipo(string token, string prefijo);
        Task<dynamic> IngresarConsultaTipo(string token, string prefijo, TipoConsulta dto);
        Task<dynamic> ActualizarConsultaTipo(string token, string prefijo, string id, TipoConsulta dto);
        Task<dynamic> DeleteConsultaTipo(string token, string prefijo, string id);
        Task<ConsultasDto> UltimaConsultaMascota(string token, string prefijo, string idMascota);
    }
}
