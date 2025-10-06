namespace SistemaVeterinario.Backend.Entities.Requests
{
    public class MascotaDtoRequest
    {
        public string IdMascota { get; set; } = null!;

        public string RutCliente { get; set; } = null!;

        public string NombreMascota { get; set; } = null!;

        public string CodSexo { get; set; } = null!;

        public string CodEspecie { get; set; } = null!;

        public string CodRaza { get; set; } = null!;

        public string FechaNacimiento { get; set; }

        public string CodColor { get; set; } = null!;

        public string IdFotoPerfil { get; set; } = null!;

        public string IdEstado { get; set; } = null!;

        public string FechaCreacion { get; set; }

        public string Microchip { get; set; } = null!;

        public string EstadoReproductivo { get; set; } = null!;

        public string UltimaModificacion { get; set; }

        public string NumeroHospitalizacion { get; set; } = null!;
    }
}
