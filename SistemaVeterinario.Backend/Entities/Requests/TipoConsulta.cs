namespace SistemaVeterinario.Backend.Entities.Requests
{
    public class TipoConsulta
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public double Valor { get; set; }
        public bool Activo { get; set; }
    }
}
