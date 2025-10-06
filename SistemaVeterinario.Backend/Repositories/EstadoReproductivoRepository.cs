using Newtonsoft.Json.Linq;

namespace SistemaVeterinario.Backend.Repositories
{
    public class EstadoReproductivoRepository : IEstadoReproductivoRepository
    {
        private readonly HttpClient httpClient;
        public EstadoReproductivoRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<dynamic> GetEstadosReproductivos(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/reproductivo/{prefijo}/obtener-estados");
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
