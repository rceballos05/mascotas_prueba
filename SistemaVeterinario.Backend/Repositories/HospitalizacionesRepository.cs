using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Interfaces;

namespace SistemaVeterinario.Backend.Repositories
{
    public class HospitalizacionesRepository : IHospitalizacionesRepository
    {
        private readonly HttpClient httpClient;

        public HospitalizacionesRepository(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<List<HospitalizacionesDto>> GetHospitalizaciones(string token, string prefijo, string id)
        {
            try
            {
                List<HospitalizacionesDto> lst = new List<HospitalizacionesDto>();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/Hospitalizacion/{prefijo}/listado-hospitalizaciones/{id}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    
                    foreach(var item in rsp.items)
                    {
                        lst.Add(new HospitalizacionesDto
                        {
                            AsuntoIngreso = item.asuntoIngreso,
                            BoxIngreso = item.boxIngreso,
                            CajaPresupuesto = item.cajaPresupuesto,
                            Dieta = item.dieta,
                            FechaAlta = item.fechaAlta,
                            FechaCreacion = item.fechaCreacion,
                            FechaIngreso = item.fechaIngreso,
                            GlosaAlta = item.glosaAlta,
                            HoraAlta = item.horaAlta,
                            HoraIngreso = item.horaIngreso,
                            IdMascota = item.idMascota,
                            IdProfesional = item.idProfesional,
                            Local = item.local,
                            MedicoHospital = item.medicoHospital,
                            Numero = item.numero,
                            NumeroPresupuesto = item.numeroPresupuesto,
                            Peso = item.peso,
                            ProfesionalAlta = item.profesionalAlta,
                            RutCliente = item.rutCliente,
                            Total = item.total,
                            Especialista = item.especialista
                        });
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
    }
}
