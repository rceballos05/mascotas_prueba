
using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Interfaces;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{

    public class RazaRepository : IRazaRepository
    {
        private readonly HttpClient httpClient;
        public RazaRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<dynamic> DeleteRaza(string token, string prefijo, string idEspecie, string idRaza)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.DeleteAsync($"api/raza/{prefijo}/raza/{idEspecie}/{idRaza}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
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

        public async Task<dynamic> GetRaza(string token, string prefijo, string idEspecie, string idRaza)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/raza/{prefijo}/obtener-raza/{idEspecie}/{idRaza}");
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

        public async Task<List<RazaDto>> GetRazas(string token, string prefijo, string idEspecie)
        {
            try
            {
                List<RazaDto> lst = new List<RazaDto>();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/raza/{prefijo}/obtener-razas/{idEspecie}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        lst.Add(new RazaDto { Activo = item.activo == 0? false : true, Id = item.idRaza, Nombre = item.raza});
                    }
                }
                return lst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> NumeroRaza(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/raza/{prefijo}/numero-raza");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    int numero = Convert.ToInt32(rsp.items[0]) + 1;
                    return numero.ToString().PadLeft(3,'0');
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> PostRaza(string token, string prefijo,string idEspecie, RazaDto dto)
        {
            try
            {
                RazaDtoRequest request = new RazaDtoRequest
                {
                    Activo = dto.Activo == true ? 1 : 0,
                    IdEspecie = idEspecie,
                    IdRaza = dto.Id,
                    Raza = dto.Nombre
                };
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/raza/{prefijo}/raza", content);
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

        public async Task<dynamic> PutRaza(string token, string prefijo,string idEspecie, RazaDto dto)
        {
            try
            {
                RazaDtoRequest request = new RazaDtoRequest {
                    Activo = dto.Activo == true ? 1 : 0,
                    IdEspecie = idEspecie,
                    IdRaza = dto.Id,
                    Raza = dto.Nombre
                };
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PutAsync($"api/raza/{prefijo}/raza", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
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
