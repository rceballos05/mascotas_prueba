using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class ControlesRepository : IControlesRepository
    {
        private readonly HttpClient httpClient;
        public ControlesRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<List<ControlDto>> ControlesMascota(string token, string prefijo, string idMascota)
        {
            try
            {
                List<ControlDto> controles = new List<ControlDto>();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Controles/{prefijo}/listado-controles/{idMascota}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        controles.Add(new ControlDto
                        {
                            CodigoControl = item.idControl,
                            Estado = item.estado,
                            FechaControl = Convert.ToDateTime(item.fechaEmision).ToString("dd-MM-yyyy"),
                            Motivo = item.motivo,
                            Observaciones = "item."

                        });
                    }
                    return controles;
                }
                return controles;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public async Task<dynamic> ControlesTipo(string token, string prefijo, string idTipo)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/controles/{prefijo}/tipo-control/{idTipo}");
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

        public async Task<ControlDto> UltimoControlMascota(string token, string prefijo, string idMascota)
        {
            try
            {
                ControlDto controles = new();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Controles/{prefijo}/listado-controles/{idMascota}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        controles=new ControlDto
                        {
                            CodigoControl = item.idControl,
                            Estado = item.estado,
                            FechaControl = Convert.ToDateTime(item.fechaEmision).ToString("dd-MM-yyyy"),
                            Motivo = item.motivo,
                            Observaciones = "item."

                        };
                    }
                    
                }
                return controles;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
