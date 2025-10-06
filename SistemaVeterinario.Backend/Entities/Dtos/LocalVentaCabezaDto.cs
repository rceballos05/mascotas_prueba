namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class LocalVentaCabezaDto
    {
        public string Local { get; set; } = null!;

        public string TipoDoc { get; set; } = null!;

        public string NumeroDoc { get; set; } = null!;

        public string CajaDoc { get; set; } = null!;

        public DateTime FechaEmision { get; set; }

        public string Foliosii { get; set; } = null!;

        public DateTime Vencimiento { get; set; }

        public string RutCliente { get; set; } = null!;

        public string DireccionDestino { get; set; } = null!;

        public string RutCajera { get; set; } = null!;

        public string NotaPedido { get; set; } = null!;

        public string OrdenDeCompra { get; set; } = null!;

        public double Subtotal { get; set; }

        public double MontoNeto { get; set; }

        public double MontoIva { get; set; }

        public string Plazo { get; set; } = null!;

        public double ImpHarina { get; set; }

        public double ImpCarne { get; set; }

        public double ImpRefrescos { get; set; }

        public double ImpLicores { get; set; }

        public double ImpVinos { get; set; }

        public double ImpLight { get; set; }

        public double ImpCerveza { get; set; }

        public double ImpDiesel { get; set; }

        public double MontoExento { get; set; }

        public double MontoTotal { get; set; }

        public double MontoLey20956 { get; set; }

        public double Abono { get; set; }

        public double MontoDonacion { get; set; }

        public string HoraVenta { get; set; } = null!;

        public string HoraVendedor { get; set; } = null!;

        public string RutVendedor { get; set; } = null!;

        public double Dctoglobal { get; set; }

        public double PorceDescuento { get; set; }

        public string Formapago { get; set; } = null!;

        public string DespachoPatente { get; set; } = null!;

        public DateTime DespachoFecha { get; set; }

        public string DespachoFolio { get; set; } = null!;

        public string DespachoHora { get; set; } = null!;

        public string GlosaGuia { get; set; } = null!;

        public string UsuarioFacturacion { get; set; } = null!;

        public string Observacion { get; set; } = null!;

        public string RefTipo { get; set; } = null!;

        public DateTime RefFecha { get; set; }

        public string RefNumero { get; set; } = null!;

        public string RefGlosa { get; set; } = null!;

        public string NombreCliente { get; set; } = null!;

        public string FonoCliente { get; set; } = null!;

        public string EmailCliente { get; set; } = null!;

        public int Revision1 { get; set; }

        public int Revision2 { get; set; }

        public int Revision3 { get; set; }

        public int GenerarDte { get; set; }

        public string NumeroImpresora { get; set; } = null!;

        public int Procesada { get; set; }

        public string Acteco { get; set; } = null!;

        public sbyte ImprimePorGrupos { get; set; }

        public string TipoTraslado { get; set; } = null!;

        public double MontoPropina { get; set; }

        public string LocalTraslado { get; set; } = null!;

        public string Nroconsulta { get; set; } = null!;

        public string? Especialista { get; set; }

        public string? Ayudante { get; set; }

        public string Crcc { get; set; } = null!;

        public string CodigoPlan { get; set; } = null!;

        public double AhorraPlan { get; set; }

        public string NroMascota { get; set; } = null!;
    }
}
