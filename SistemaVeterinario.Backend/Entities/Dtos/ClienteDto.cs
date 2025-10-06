namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class ClienteDto
    {
        public string Rut { get; set; } = "";

        public string Nombre { get; set; } = "";

        public string Direccion { get; set; } = "";

        public string CodComuna { get; set; } = "";

        public string Comuna { get; set; } = "";

        public string Ciudad { get; set; } = "";

        public string? Sector { get; set; }

        public string? Fono1 { get; set; } = "";

        public string? Fono2 { get; set; } = "";

        public string? Fax { get; set; } = "";

        public string Celular { get; set; } = "";

        public string? Giro { get; set; } = "";

        public string Email { get; set; } = "";

        public int Diascredito { get; set; }

        public string? Contacto { get; set; } = "";

        public string? ContactoMail { get; set; }

        public string? ContactoFono { get; set; }

        public double Descuento { get; set; }

        public string Bloqueo { get; set; } = "";

        public string BloqueoFacturas { get; set; } = "";

        public string Tipocliente { get; set; } = "";

        public string Plazo { get; set; } = "";

        public double Cupo { get; set; }

        public double Disponible { get; set; }

        public string Vendedor { get; set; } = "";

        public string Canalcliente { get; set; } = "";

        public string? Ultimamodificacion { get; set; }

        public string? Localcreacion { get; set; }

        public string? Ingreso { get; set; }

        public sbyte Activo { get; set; }

        public string CodPrecio { get; set; } = "";

        public sbyte PrecioMenor { get; set; }

        public string? WebPassword { get; set; }

        public string? CodigoListaPrecios { get; set; }

        public double TarjetaCupo { get; set; }

        public double TarjetaDiaPago { get; set; }

        public sbyte TerceraEdad { get; set; }

        public string? DctoSeccion { get; set; }

        public string? DctoDepto { get; set; }

        public sbyte EsInstitucionPublica { get; set; }
    }
}
