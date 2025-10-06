using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class EspecialistaRepository : IEspecialistaRepository
    {
        private readonly HttpClient httpClient;
        public EspecialistaRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }
        public async Task<SeguUsuarios> GetEspecialistaByCode(string token, string prefijo, string local, int codigo)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/especialistas/{prefijo}/{local}/especialista/{codigo}");
                var responseString = await response.Content.ReadAsStringAsync();
                SeguUsuarios Especialista = new();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    var esp = rsp.items[0];
                    Especialista = new SeguUsuarios
                    {
                        Rut = esp.rut,
                        Usuario = esp.usuario,
                        Activo = esp.activo,
                        Nombre = esp.nombre,
                        Labor = esp.labor,
                    };
                }
                return Especialista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<SeguUsuarios>> GetEspecialistas(string token, string prefijo, string local)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/especialistas/{prefijo}/{local}/especialistas");
                var responseString = await response.Content.ReadAsStringAsync();
                List<SeguUsuarios> Especialistas = new();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        SeguUsuarios add = new SeguUsuarios
                        {
                            Rut = item.rut,
                            Usuario = item.usuario,
                            Activo = item.activo,
                            Nombre = item.nombre,
                            Labor = item.labor,
                            Codigoprofesional = item.codigoprofesional,
                        };
                        Especialistas.Add(add);
                    }

                    
                }
                return Especialistas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<SeguUsuarios>> GetMedicos(string token, string prefijo, string local)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/especialistas/{prefijo}/{local}/medicos");
                var responseString = await response.Content.ReadAsStringAsync();
                List<SeguUsuarios> Especialistas = new();
                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    
                   foreach(var item in rsp.items)
                    {
                        SeguUsuarios add = new SeguUsuarios
                        {
                            Rut = item.rut,
                            Usuario = item.usuario,
                            Activo = item.activo,
                            Nombre = item.nombre,
                            Labor = item.labor,
                            Codigoprofesional = item.codigoprofesional,
                        };
                        Especialistas.Add(add);
                    }
                    
                }
                return Especialistas;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
