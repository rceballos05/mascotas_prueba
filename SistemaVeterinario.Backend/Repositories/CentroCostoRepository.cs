using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class CentroCostoRepository : ICentroCostoRepository
    {
        private readonly HttpClient httpClient;
        public CentroCostoRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<List<CentroCosto>> GetCentros(string token, string prefijo)
        {
            try
            {
                List<CentroCosto> centroCostos = new List<CentroCosto>();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/centros-costos/{prefijo}/centros");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);
                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        Console.WriteLine(item);

                        centroCostos.Add(new CentroCosto { 
                            CodigoCrcc = item.codigoCrcc,
                            CodigoEmpresa = item.codigoEmpresa,
                            Descripcion = item.descripcion
                        });
                    }
                    return centroCostos;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
