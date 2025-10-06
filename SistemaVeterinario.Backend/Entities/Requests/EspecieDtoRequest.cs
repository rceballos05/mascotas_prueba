using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.Backend.Entities.Requests
{
    public class EspecieDtoRequest
    {
        public string CodEspecie { get; set; } = null!;

        public string? Especie { get; set; }
    }
}
