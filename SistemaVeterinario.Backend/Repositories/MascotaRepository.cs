
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Entities.Responses;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class MascotaRepository : IMascotaRepository
    {
        private static readonly JsonSerializerOptions SerializerOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        private readonly HttpClient httpClient;
        private readonly ILogger<MascotaRepository> logger;

        public MascotaRepository(HttpClient httpClient, ILogger<MascotaRepository> logger)
        {
            this.httpClient = httpClient;
            this.logger = logger;
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

        public async Task<string?> GetNumeroMascota(string token, string prefijo)
        {
            try
            {
                SetAuthorization(token);

                using var response = await httpClient.GetAsync($"api/Mascotas/{prefijo}/numero-mascota");
                var payload = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    logger.LogWarning("No se pudo obtener el correlativo de mascota para el prefijo {Prefijo}. Código {StatusCode}. Respuesta: {Payload}", prefijo, response.StatusCode, payload);
                    throw new HttpRequestException($"Error al obtener número de mascota ({(int)response.StatusCode}). {payload}");
                }

                var envelope = JsonSerializer.Deserialize<ApiResponse<List<string>>>(payload, SerializerOptions);
                if (envelope?.Items is null || envelope.Items.Count == 0)
                {
                    logger.LogInformation("La respuesta de número de mascota para el prefijo {Prefijo} no contiene elementos.", prefijo);
                    return null;
                }

                var numeroOrigen = envelope.Items[0];
                if (!int.TryParse(numeroOrigen, out var numeroActual))
                {
                    logger.LogWarning("El número de mascota '{NumeroOrigen}' no es válido.", numeroOrigen);
                    return null;
                }

                return (numeroActual + 1).ToString("D10");
            }
            catch (HttpRequestException)
            {
                throw;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error inesperado al obtener el número de mascota");
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

        private void SetAuthorization(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                httpClient.DefaultRequestHeaders.Authorization = null;
                return;
            }

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
