namespace SistemaVeterinario.Backend.Statics
{
    public class BaseEntityResponsePaginated<T>
    {
        public int? StatusCode { get; set; }
        public string? Message { get; set; }
        public int? TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public List<T>? Items { get; set; }
    }
}
