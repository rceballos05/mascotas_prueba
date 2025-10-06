using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Interfaces;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly HttpClient httpClient;
        public LoginRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<dynamic> IniciarSesion(LoginRequest request)
        {
            try
            {
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //var response = await httpClient.PostAsync("api/sales-administrator/login", content);
                var response = await httpClient.PostAsync("api/sales-administrator/login", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return rsp;
                }
                return null;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }


        }
    }
}
