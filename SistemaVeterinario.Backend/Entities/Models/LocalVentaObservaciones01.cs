namespace SistemaVeterinario.Backend.Entities.Models
{
    public class LocalVentaObservaciones01
    {
        public string Local { get; set; } = null!;

        public string TipoDoc { get; set; } = null!;

        public string NumeroDoc { get; set; } = null!;

        public DateTime FechaEmision { get; set; }

        public string RutCliente { get; set; } = null!;

        public string CajaDoc { get; set; } = null!;

        public string LineaVenta { get; set; } = null!;

        public string Codigo { get; set; } = null!;

        public string Observaciones { get; set; } = null!;
    }
}
