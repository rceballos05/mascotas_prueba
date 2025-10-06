namespace SistemaVeterinario.Backend.Entities.Models
{
    public class MedMascotaFotos
    {
        public string IdFoto { get; set; } = null!;

        public string IdMascota { get; set; } = null!;

        public string IdCliente { get; set; } = null!;

        public string? Url { get; set; }
    }
}
