
using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class RecetasRepository : IRecetasRepository
    {
        private readonly HttpClient httpClient;

        public RecetasRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<List<RecetasDto>> GetRecetas(string token, string prefijo, string rut, string id)
        {
            try
            {
                List<RecetasDto> Recetas = new List<RecetasDto>();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/recetas/{prefijo}/obtener-receta/{rut}/{id}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach(var item in rsp.items)
                    {
                        Recetas.Add(new RecetasDto
                        {
                            BoxCreacion = item.boxCreacion,
                            FechaCreacion = Convert.ToString(item.fechaCreacion).Split(" ")[0],
                            HoraCreacion = item.horaCreacion,
                            IdMascota = item.idMascota,
                            IdOrigen = item.idOrigen,
                            IdProfesional = item.idProfesional,
                            Local = item.local,
                            NombreProfesional = item.nombreProfesional,
                            Numero = item.numero,
                            Receta = item.receta,
                            RutCliente = item.rutCliente,
                            TipoOrigen = item.tipoOrigen
                        });
                    }
                }
                return Recetas;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
