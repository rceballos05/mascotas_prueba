using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Statics;

namespace SistemaVeterinario.Backend.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<ProductosDtoResponse>> GetProductos(string token, string prefijo, int page, int cantidadItems);
        Task<dynamic> GetProducto(string token, string prefijo, string id);
        Task<BaseEntityResponsePaginated<ProductosDtoResponse>> GetProductoBusqueda(string token, string prefijo, string palabra, int page, int cantidadItems);
    }
}
