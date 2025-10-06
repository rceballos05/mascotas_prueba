namespace SistemaVeterinario.Backend.Entities.Dtos
{
    public class TipoConsultaDtoRequest
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public double Valor { get; set; }
        public sbyte Activo { get; set; }
    }
}
