
using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class ComunasRepository : IComunasRepository
    {
        private readonly HttpClient httpClient;
        public ComunasRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<dynamic> GetComunas(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/comunas/{prefijo}/comunas");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);
                List<ComunaDto> comunas = [];
                if (rsp.statusCode == 200)
                {
                    foreach(var item in rsp.items)
                    {
                        Console.WriteLine(item);
                        ComunaDto comuna = new ComunaDto();
                        comuna.Nombre = item.nombre;
                        comuna.Codigo = item.codigo;
                        comunas.Add(comuna);
                    }
                    return comunas;
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
