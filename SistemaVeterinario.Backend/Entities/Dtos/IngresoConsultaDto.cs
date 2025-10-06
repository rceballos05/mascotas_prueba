namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class IngresoConsultaDto
    {
        public string NumeroConsulta { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroFicha { get; set; }
        public string NombreMascota { get; set; }
        public string RutPropietario { get; set; }
        public string NombrePropietario { get; set; }
        public string TipoConsulta { get; set; }
        public string LugarConsulta { get; set; }
        public string Edad { get; set; }
        public bool Hospitalizacion { get; set; }
        public string Anamnesis { get; set; }
        public string Peso { get; set; }
        public string FrecuenciaCardiaca { get; set; }
        public string Temperatura { get; set; }
        public string FrecRespiratoria { get; set; }
        public string PreDiagnostico { get; set; }
        public string Complementario { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observacion { get; set; }
    }
}
