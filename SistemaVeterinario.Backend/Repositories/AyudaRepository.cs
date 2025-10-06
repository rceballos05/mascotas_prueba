using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaVeterinario.Backend.Repositories
{
    public class AyudaRepository : IAyudaRepository
    {
        private readonly HttpClient httpClient;
        public AyudaRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<dynamic> AyudaPropietario(string token,string prefijo,string palabra)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/clientes/{prefijo}/cliente-ayuda/{palabra}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return rsp.items;
                }
                return null;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public async Task<dynamic> AyudaPaciente(string token, string prefijo, AyudaPacienteDtoRequest request)
        {
            try
            {
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/Mascotas/{prefijo}/ayuda-mascotas", content);
                //var response = await httpClient.PostAsync("api/Mascotas/test/ayuda-mascotas", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return rsp.items;
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
