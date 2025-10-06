using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Interfaces;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class MascotasFotosRepository : IMascotasFotosRepository
    {
        private readonly HttpClient httpClient;
        public MascotasFotosRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<MedMascotaFotos> GetFotoMascota(string token, string prefijo, string id)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/mascotasfotos/{prefijo}/imagen/{id}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                MedMascotaFotos fotos = new MedMascotaFotos();
                if (rsp.statusCode == 200)
                {
                    
                    foreach(var item in rsp.items)
                    {
                        fotos.IdMascota = item.idMascota;
                        fotos.IdFoto = item.idFoto;
                        fotos.IdCliente = item.idCliente;
                        fotos.Url = item.url;
                    }
                }
                return fotos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> IdFoto(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/mascotasfotos/{prefijo}/imagen-id");
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

        public async Task<dynamic> PostFotoMascota(string token, string prefijo, MedMascotaFotos md)
        {
            try
            {
                var json = JsonSerializer.Serialize(md);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync($"api/mascotasfotos/{prefijo}/imagen", content);
                var responseString = await response.Content.ReadAsStringAsync();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 201)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> PutFotoMascota(string token, string prefijo, MedMascotaFotos md)
        {
            try
            {
                var json = JsonSerializer.Serialize(md);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync($"api/mascotasfotos/{prefijo}/imagen", content);
                var responseString = await response.Content.ReadAsStringAsync();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
