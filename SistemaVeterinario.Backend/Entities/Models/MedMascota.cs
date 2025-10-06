using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.Backend.Entities.Models
{
    public class MedMascota
    {
        public string idMascota { get; set; } = null!;

        public string rutCliente { get; set; } = null!;

        public string nombreMascota { get; set; } = null!;

        public string codSexo { get; set; } = null!;

        public string codEspecie { get; set; } = null!;

        public string codRaza { get; set; } = null!;

        public DateTime fechaNacimiento { get; set; }

        public string codColor { get; set; } = null!;

        public string idFotoPerfil { get; set; } = null!;

        public string idEstado { get; set; } = null!;

        public DateTime fechaCreacion { get; set; }

        public string microchip { get; set; } = null!;

        public string estadoReproductivo { get; set; } = null!;

        public DateTime ultimaModificacion { get; set; }

        public string numeroHospitalizacion { get; set; } = null!;
    }
}
