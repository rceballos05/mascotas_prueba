using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class RecetasDto
    {
        public int Numero { get; set; }

        public string TipoOrigen { get; set; } = null!;

        public string IdOrigen { get; set; } = null!;

        public string IdMascota { get; set; } = null!;
        public string NombreProfesional { get; set; } = null!;

        public string RutCliente { get; set; } = null!;

        public string Receta { get; set; } = null!;

        public int IdProfesional { get; set; }

        public string FechaCreacion { get; set; }

        public string HoraCreacion { get; set; }

        public string BoxCreacion { get; set; } = null!;

        public string Local { get; set; } = null!;
    }
}
