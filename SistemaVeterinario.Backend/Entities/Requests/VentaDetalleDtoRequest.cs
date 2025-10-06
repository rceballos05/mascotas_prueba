using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;

namespace SistemaVeterinario.Backend.Entities.Requests
{
    public class VentaDetalleDtoRequest
    {
        public List<LocalVentaDetalleDto> Ventas { get; set; }   
    }
}
