namespace SistemaVeterinario.Backend.Entities.Models
{
    public class AdmUser
    {
        public string rut { get; set; } = null!;

        public string usuario { get; set; } = null!;

        public string clave { get; set; } = null!;

        public string nombres { get; set; } = null!;

        public string apellidos { get; set; } = null!;

        public string cargo { get; set; } = null!;

        public string email { get; set; } = null!;

        public int activo { get; set; }

        public byte[] imgPerfil { get; set; } = null!;

        public DateTime fechaActivacion { get; set; }

        public TimeSpan horaActivacion { get; set; }

        public DateTime fechaBloqueo { get; set; }

        /// <summary>
        /// 00 DESACTIVAD0 - 01 NORMAL - 02 CONFIGURACION - 03 SUPER ADMIN
        /// </summary>
        public string nivelUsuario { get; set; } = null!;
    }
}
