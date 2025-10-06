using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Entities.Responses;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IVentaRepository
    {
        Task<dynamic> PostVentaCabeza(string token, string prefijo, string local, LocalVentaCabezaDto request);
        Task<dynamic> PostVentaDetalle(string token, string prefijo, string local, List<LocalVentaDetalleDto> request);
        Task<dynamic> PostVentaObservaciones(string token, string prefijo, string local, LocalVentaObservaciones01 request);
        Task<string> GetNumeroPreventa(string token, string prefijo, string local,string caja);
        Task<dynamic> GetVenta(string token, string prefijo, string local,string caja,string tipo, string numero);
        Task<List<HistorialDtoResponse>> GetHistorial(string token, string prefijo, string local, string numero, string caja);
        byte[] GenerarDocumento(MascotasDto mascotaDtoRequest, Propietario propietario,LocalVentaCabezaDto cabeza01, VentaDetalleDtoRequest detalleDtoRequest);
    }
}
