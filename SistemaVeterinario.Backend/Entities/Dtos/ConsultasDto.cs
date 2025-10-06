namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class ConsultasDto
    {
        public string CodigoConsulta { get; set; }
        public string FechaConsulta { get; set; }
        public string Edad { get; set; }
        public string Peso { get; set; }
        public string TipoExamen { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }
    }

    public class ConsultaDtoResponse
    {
        public List<ConsultasDto> Consultas { get; set; }
    }
}
