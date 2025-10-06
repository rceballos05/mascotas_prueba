namespace SistemaVeterinario.Backend.Entities.Models
{
    public class LocalVentaDetalle01
    {
        public string Local { get; set; } = null!;

        public string TipoDoc { get; set; } = null!;

        public string NumeroDoc { get; set; } = null!;

        public string CajaDoc { get; set; } = null!;

        public string LineaVenta { get; set; } = null!;

        public DateTime FechaEmision { get; set; }

        public string RutCliente { get; set; } = null!;

        public string DestinoCliente { get; set; } = null!;

        public string ArtCodigo { get; set; } = null!;

        public string ArtDescripcion { get; set; } = null!;

        public double ArtCantidad { get; set; }

        public double ArtPrecio { get; set; }

        public double ArtDescuento { get; set; }

        public double PorceDescuento { get; set; }

        public double TotalLinea { get; set; }

        public string RutVendedor { get; set; } = null!;

        public double PrecioCostoCiva { get; set; }

        public string Almacen { get; set; } = null!;

        public string Impuesto { get; set; } = null!;

        public double PorceImpuesto { get; set; }

        public double MontoImpuesto { get; set; }

        public double Descuento { get; set; }

        public string Horaventa { get; set; } = null!;

        public string UsuarioFacturacion { get; set; } = null!;

        public string Foliosii { get; set; } = null!;

        public string Fechaviaje { get; set; } = null!;

        public string RefTipo { get; set; } = null!;

        public string RefNumero { get; set; } = null!;

        public string RefFecha { get; set; } = null!;

        public string CodigoRelacion { get; set; } = null!;

        public string NroMascota { get; set; } = null!;

        public string NroConsulta { get; set; } = null!;

        public string MontoRecargo { get; set; } = null!;
    }
}
