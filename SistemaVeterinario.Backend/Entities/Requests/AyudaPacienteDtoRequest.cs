namespace SistemaVeterinario.Backend.Entities.Requests
{
    public class AyudaPacienteDtoRequest
    {
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public string? Raza { get; set; }
        public string? NombrePropietario { get; set; }
        public string? Microchip { get; set; }
        public string? Sexo { get; set; }
        public string? ciudad { get; set; }
        public string? Color { get; set; }
    }
}
