using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class MascotasDto
    {
        public string IdMascota { get; set; } = null!;

        public string RutCliente { get; set; } = null!;

        public string NombreMascota { get; set; } = null!;

        public string CodSexo { get; set; } = null!;
        public string Sexo { get; set; } = null!;

        public string CodEspecie { get; set; } = null!;
        public string Especie { get; set; } = null!;


        public string CodRaza { get; set; } = null!;
        public string Raza { get; set; } = null!;

        public DateTime FechaNacimiento { get; set; }

        public string CodColor { get; set; } = null!;
        public string Color { get; set; } = null!;

        public string IdFotoPerfil { get; set; } = null!;

        public string IdEstado { get; set; } = null!;
        public string Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string Microchip { get; set; } = null!;

        public string EstadoReproductivo { get; set; } = null!;
        public string CodEstadoReproductivo { get; set; } = null!;

        public DateTime UltimaModificacion { get; set; }

        public string NumeroHospitalizacion { get; set; } = null!;
    }
}
