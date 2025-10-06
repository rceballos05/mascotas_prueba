using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class PropietarioRepository : IPropietarioRepository
    {
        private readonly HttpClient httpClient;
        public PropietarioRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<dynamic> GetPropietario(string token,string rut, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/clientes/{prefijo}/detalle-cliente/{rut}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return rsp.items[0];
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> PostPropietario(string token, ClienteDto request, string prefijo)
        {
            try
            {
                
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //var response = await httpClient.PostAsync("api/sales-administrator/login", content);
                var response = await httpClient.PostAsync($"api/clientes/{prefijo}/ingresar-cliente", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return rsp;
                }
                return rsp;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
