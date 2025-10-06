namespace SistemaVeterinario.Backend.Entities.Models
{
    public class ControlUsuarioClinica
    {
        public string Usuariosistema { get; set; } = null!;

        public DateTime Fecha { get; set; }

        public TimeOnly Hora { get; set; }

        public string Programa { get; set; } = null!;

        public string? Accion { get; set; }

        public string? Formulario { get; set; }

        public string? Datos { get; set; }
    }
}
