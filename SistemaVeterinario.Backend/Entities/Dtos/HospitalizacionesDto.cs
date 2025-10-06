using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class HospitalizacionesDto
    {
        public string Local { get; set; } = null!;

        public string Numero { get; set; } = null!;

        public string FechaIngreso { get; set; }

        public string HoraIngreso { get; set; }

        public string BoxIngreso { get; set; } = null!;

        public double Total { get; set; }

        public string IdMascota { get; set; } = null!;

        public string RutCliente { get; set; } = null!;
        public string Especialista { get; set; } = null!;
        public string AsuntoIngreso { get; set; } = null!;

        public string Dieta { get; set; } = null!;

        public double Peso { get; set; }

        public int IdProfesional { get; set; }

        public string FechaCreacion { get; set; }

        public string HoraAlta { get; set; }

        public string FechaAlta { get; set; }

        public string GlosaAlta { get; set; } = null!;

        public int ProfesionalAlta { get; set; }

        public string NumeroPresupuesto { get; set; } = null!;

        public string CajaPresupuesto { get; set; } = null!;

        public int MedicoHospital { get; set; }
    }
}
