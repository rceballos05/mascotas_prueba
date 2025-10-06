
using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Interfaces;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class MascotaRepository : IMascotaRepository
    {
        private readonly HttpClient httpClient;

        public MascotaRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<dynamic> DeleteMascota(string token, string prefijo, string id)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.DeleteAsync($"api/Mascotas/{prefijo}/eliminar-mascota/{id}");
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

        public async Task<dynamic> GetMascota(string token, string prefijo, string id)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Mascotas/{prefijo}/detalle-mascota/{id}");
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

        public async Task<dynamic> GetMascotaRutCliente(string token, string prefijo, string rut)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Mascotas/{prefijo}/obtener-mascotas/{rut}");
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

        public async Task<dynamic> GetNumeroMascota(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Mascotas/{prefijo}/numero-mascota");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    string numero = rsp.items[0];
                    string nuevoNumero = Convert.ToString((Convert.ToInt32(numero) + 1)).PadLeft(10,'0');
                    return nuevoNumero;
                }
                return null;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public async Task<dynamic> PostMascota(string token, string prefijo, MascotaDtoRequest mascota)
        {
            try
            {
                mascota.RutCliente = mascota.RutCliente.ToUpper();
                mascota.NombreMascota = mascota.NombreMascota.ToUpper();
                mascota.CodColor = mascota.CodColor.ToUpper();
                var json = JsonSerializer.Serialize(mascota);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //var response = await httpClient.PostAsync("api/sales-administrator/login", content);
                var response = await httpClient.PostAsync($"api/Mascotas/{prefijo}/mascota", content);
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

        public async Task<dynamic> PutMascota(string token, string prefijo, MascotaDtoRequest mascota)
        {
            try
            {
                mascota.RutCliente = mascota.RutCliente.ToUpper();
                mascota.NombreMascota = mascota.NombreMascota.ToUpper();
                mascota.CodColor = mascota.CodColor.ToUpper();
                var json = JsonSerializer.Serialize(mascota);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //var response = await httpClient.PostAsync("api/sales-administrator/login", content);
                var response = await httpClient.PutAsync($"api/Mascotas/{prefijo}/editar-mascota", content);
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
