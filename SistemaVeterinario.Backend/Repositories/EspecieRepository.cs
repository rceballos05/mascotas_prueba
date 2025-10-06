
using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Interfaces;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class EspecieRepository : IEspecieRepository
    {
        private readonly HttpClient httpClient;
        public EspecieRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<dynamic> DeleteEspecie(string token, string prefijo, string id)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.DeleteAsync($"api/especies/{prefijo}/eliminar-especie/{id.PadLeft(3, '0')}");
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

        public async Task<dynamic> GetEspecie(string token, string prefijo, string id)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/especies/{prefijo}/obtener-especie/{id.PadLeft(3,'0')}");
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

        public async Task<List<EspecieDto>> GetEspecies(string token, string prefijo)
        {
            try
            {
                List<EspecieDto> lst = new List<EspecieDto>();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/especies/{prefijo}/obtener-especies");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        //Console.WriteLine(item);
                        lst.Add(new EspecieDto { Id = item.codEspecie, Nombre = item.especie });
                    }
                }
                return lst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> GetNumeroEspecie(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/especies/{prefijo}/numero-especie");
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

        public async Task<dynamic> PostEspecie(string token, string prefijo, EspecieDto dto)
        {
            try
            {
                EspecieDtoRequest request = new EspecieDtoRequest { 
                    CodEspecie = dto.Id,
                    Especie = dto.Nombre
                };
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/especies/{prefijo}/ingresar-especie", content);
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

        public async Task<dynamic> PutEspecie(string token, string prefijo, EspecieDto dto)
        {
            try
            {
                EspecieDtoRequest request = new EspecieDtoRequest
                {
                    CodEspecie = dto.Id,
                    Especie = dto.Nombre
                };
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/especies/{prefijo}/editar-especie/", content);
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
