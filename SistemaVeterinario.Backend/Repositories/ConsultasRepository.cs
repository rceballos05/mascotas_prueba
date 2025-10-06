using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Interfaces;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
namespace SistemaVeterinario.Backend.Repositories
{
    public class ConsultasRepository : IConsultasRepository
    {
        private readonly HttpClient httpClient;
        public ConsultasRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<dynamic> ActualizarConsultaTipo(string token, string prefijo, string id, TipoConsulta dto)
        {
            TipoConsultaDtoRequest request = new TipoConsultaDtoRequest
            {
                Activo = SByte.Parse(dto.Activo == true ? "1" : "0"),
                ID = dto.ID,
                Nombre = dto.Nombre,
                Valor = dto.Valor
            };
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PutAsync($"api/Consultas/{prefijo}/tipo-consulta/{id}", content);
                var responseString = await response.Content.ReadAsStringAsync();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return true;
                }
                return null;
            }
            catch (Exception e)
            {

                var error = e.Message;
                throw;
            }
        }

        public async Task<List<TipoConsulta>> Consultas(string token, string prefijo)
        {
            try
            {
                List<TipoConsulta> lst = new List<TipoConsulta>();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/tipo-consulta");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        Console.WriteLine(item);
                        lst.Add(new TipoConsulta { ID = item.id, Nombre = item.nombre, Activo = item.activo == 0 ? false : true, Valor = item.valor });
                    }
                }
                return lst;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public async Task<List<ConsultasDto>> ConsultasMascota(string token, string prefijo, string idMascota)
        {
            try
            {
                List<ConsultasDto> consultas = new List<ConsultasDto>();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/listado-consultas/{idMascota}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        var tipo = await ConsultasTipo("", "test", (string)item.codExamen);
                        consultas.Add(new ConsultasDto
                        {
                            CodigoConsulta = item.idConsulta ?? "",
                            Diagnostico = item.glosaDiagnostico ?? "",
                            Edad = item.edadMascota ?? "",
                            FechaConsulta = Convert.ToString(item.fechaEmision ?? "").Split(" ")[0],
                            Observaciones = item.observacion ?? "",
                            Peso = item.pesoMascota ?? "",
                            TipoExamen = tipo == null ? "" : tipo[0].nombre,
                            Tratamiento = item.glosaTratamiento ?? ""
                        });
                    }
                    return consultas;
                }
                return consultas;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public async Task<dynamic> ConsultasTipo(string token, string prefijo, string idTipo)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/tipo-consulta/{idTipo}");
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

        public async Task<dynamic> DeleteConsultaTipo(string token, string prefijo, string id)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.DeleteAsync($"api/Consultas/{prefijo}/tipo-consulta/{id}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return true;
                }
                return null;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public async Task<dynamic> DetalleConsulta(string token, string prefijo, string idconsulta)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/consulta/{idconsulta}");
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

        public async Task<dynamic> IngresarConsulta(string token, string prefijo, IngresoConsultaDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync($"api/Consultas/{prefijo}/crear-consulta", content);
                var responseString = await response.Content.ReadAsStringAsync();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 201)
                {
                    return true;
                }
                return null;
            }
            catch (Exception e)
            {

                var error = e.Message;
                throw;
            }
            throw new NotImplementedException();
        }

        public async Task<dynamic> IngresarConsultaTipo(string token, string prefijo, TipoConsulta dto)
        {
            TipoConsultaDtoRequest request = new TipoConsultaDtoRequest
            {
                Activo = SByte.Parse(dto.Activo == true ? "1" : "0"),
                ID = dto.ID,
                Nombre = dto.Nombre,
                Valor = dto.Valor
            };
            var json = JsonSerializer.Serialize(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PostAsync($"api/Consultas/{prefijo}/tipo-consulta", content);
                var responseString = await response.Content.ReadAsStringAsync();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 201)
                {
                    return true;
                }
                return null;
            }
            catch (Exception e)
            {

                var error = e.Message;
                throw;
            }
        }

        public async Task<dynamic> LocacionesConsultas(string token, string prefijo)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/locaciones-consulta");
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

        public async Task<dynamic> NumeroConsulta(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/numero-consulta");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    string numero = rsp.items[0];
                    string nuevoNumero = Convert.ToString((Convert.ToInt32(numero) + 1)).PadLeft(10, '0');
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

        public async Task<dynamic> NumeroConsultaTipo(string token, string prefijo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/numero-consulta-tipo");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    string numero = rsp.items[0];
                    string nuevoNumero = Convert.ToString((Convert.ToInt32(numero) + 1)).PadLeft(3, '0');
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

        public async Task<ConsultasDto> UltimaConsultaMascota(string token, string prefijo, string idMascota)
        {
            try
            {
                ConsultasDto consultas = new ();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Consultas/{prefijo}/ultima-consulta/{idMascota}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        //var tipo = await ConsultasTipo("", "test", (string)item.codExamen);
                        consultas= new ConsultasDto
                        {
                            CodigoConsulta = item.idConsulta ?? "",
                            Diagnostico = item.glosaDiagnostico ?? "",
                            Edad = item.edadMascota ?? "",
                            FechaConsulta = Convert.ToString(item.fechaEmision ?? "").Split(" ")[0],
                            Observaciones = item.observacion ?? "",
                            Peso = item.pesoMascota ?? "",
                            
                            Tratamiento = item.glosaTratamiento ?? ""
                        };
                    }
                   
                }
                return consultas;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }

        public async Task<dynamic> UpdateConsulta(string token, string prefijo, string idconsulta, IngresoConsultaDto dto)
        {
            var json = JsonSerializer.Serialize(dto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                var response = await httpClient.PutAsync($"api/Consultas/{prefijo}/consulta/{idconsulta}", content);
                var responseString = await response.Content.ReadAsStringAsync();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return true;
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
