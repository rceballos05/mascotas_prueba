namespace SistemaVeterinario.Backend.Entities.Models
{
    public class Propietario
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string CodComuna { get; set; }
        public string Direccion { get; set; }
        public string Fono { get; set; } = "";
        public string Fono2 { get; set; } = "";
        public string Fono3 { get; set; } = "";
        public string Email { get; set; }
        public bool Bloqueo { get; set; }
        public double Cupo { get; set; }
        public double Disponible { get; set; }
        public string Plazo { get; set; }
        public double Descuento { get; set; }

    }
}
