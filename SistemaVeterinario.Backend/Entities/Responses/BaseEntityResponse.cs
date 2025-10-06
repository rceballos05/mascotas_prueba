namespace SistemaVeterinario.Backend.Entities.Responses
{
    public class BaseEntityResponse<T>
    {
        public int? StatusCode { get; set; }
        public string? Message { get; set; }
        public int? TotalRecords { get; set; }
        public List<T>? Items { get; set; }
    }
}
