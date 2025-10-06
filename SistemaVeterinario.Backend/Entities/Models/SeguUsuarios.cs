namespace SistemaVeterinario.Backend.Entities.Models
{
    public class SeguUsuarios
    {
        public string Rut { get; set; } = null!;

        public string Usuario { get; set; } = null!;

        public string Clave2 { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Labor { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Usuariomysql { get; set; } = null!;

        public string Clavesql { get; set; } = null!;

        public string Clave { get; set; } = null!;

        public bool Controlcajas { get; set; }

        public int Codigoprofesional { get; set; }

        public int Activo { get; set; }

        public sbyte SuperUsuario { get; set; }

        public sbyte MedicoHospital { get; set; }
    }
}
