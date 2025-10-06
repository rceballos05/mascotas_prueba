using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Interfaces;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class ColorRepository : IColorRepository
    {
        private readonly HttpClient httpClient;
        public ColorRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<dynamic> DeleteColor(string token, string prefijo, string id)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.DeleteAsync($"api/medcolor/{prefijo}/color/{id.PadLeft(3, '0')}");
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

        public async Task<dynamic> GetColor(string token, string prefijo, string id)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/medcolor/{prefijo}/color/{id.PadLeft(3, '0')}");
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

        public async Task<List<MedColor>> GetColores(string token, string prefijo)
        {
            try
            {
                List<MedColor> lst = new List<MedColor>();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/medcolor/{prefijo}/colores");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        Console.WriteLine(item);
                        lst.Add(new MedColor { CodColor = item.codColor, NombreColor = item.nombreColor });
                    }
                }
                return lst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> GetNumeroColor(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/medcolor/{prefijo}/numero-color");
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

        public async Task<dynamic> PostColor(string token, string prefijo, MedColor dto)
        {
            try
            {
                
                var json = JsonSerializer.Serialize(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/medcolor/{prefijo}/color", content);
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

        public async Task<dynamic> PutColor(string token, string prefijo, MedColor dto)
        {
            try
            {

                var json = JsonSerializer.Serialize(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PutAsync($"api/medcolor/{prefijo}/color", content);
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
