namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class VentaDto
    {
        public LocalVentaCabezaDto CabezaDto { get; set; }
        public List<LocalVentaDetalleDto> Detalle { get; set; }
    }
}
