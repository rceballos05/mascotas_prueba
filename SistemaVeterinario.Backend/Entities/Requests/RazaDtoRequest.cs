namespace SistemaVeterinario.Backend.Entities.Requests
{
    public class RazaDtoRequest
    {
        public string IdRaza { get; set; } = null!;

        public string IdEspecie { get; set; } = null!;

        public string Raza { get; set; } = null!;

        public int Activo { get; set; }
    }
}
