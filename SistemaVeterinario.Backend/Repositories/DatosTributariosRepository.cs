using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class DatosTributariosRepository : IDatosTributariosRepository
    {
        private readonly HttpClient httpClient;
        public DatosTributariosRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<MaeEmpresasDatos> GetDatos(string token, string prefijo, string local)
        {
            try
            {
                var Datos = new MaeEmpresasDatos();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/datos/{prefijo}/{local}/datos");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach(var item in rsp.items)
                    {
                        Datos = new MaeEmpresasDatos 
                        {
                            Rut = item.rut,
                            Fono = item.fono,
                            Comuna = item.comuna,
                            Direccion = item.direccion,
                            Email = item.email,
                            Giro1 = item.giro1,
                            Giro2 = item.giro2,
                            Giro3 = item.giro3,
                            Giro4 = item.giro4,
                            Rut2 = item.rut2,
                            CodEmpresa = item.codEmpresa,
                            RazonSocial = item.razonSocial,
                            RazonSocial2 = item.razonSocial2,
                            GlosaResolucion = item.glosaResolucion,
                            Img = item.img,
                            Sii = item.sii,
                            Rutrepresentante = item.rutrepresentante,
                            Sitioweb = item.sitioweb,
                            WebVerificacion = item.webVerificacion
                        };
                    }
                }
                return Datos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
