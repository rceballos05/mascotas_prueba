
using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class SexoRepository : ISexoRepository
    {
        private readonly HttpClient httpClient;
        public SexoRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<dynamic> GetSexos(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/sexo/{prefijo}/obtener-sexo");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return rsp.items;
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
