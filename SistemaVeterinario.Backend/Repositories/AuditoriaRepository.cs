using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Interfaces;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        private readonly HttpClient httpClient;
        public AuditoriaRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<dynamic> PostAuditoria(string token, string prefijo, ControlUsuarioClinica dto)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var json = JsonSerializer.Serialize(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync($"api/controlusuariomascotas/{prefijo}/auditoria", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 201)
                {
                    return true;
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
