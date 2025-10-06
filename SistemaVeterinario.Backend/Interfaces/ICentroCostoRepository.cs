using SistemaVeterinario.Backend.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface ICentroCostoRepository
    {
        Task<List<CentroCosto>> GetCentros(string token, string prefijo);
    }
}
