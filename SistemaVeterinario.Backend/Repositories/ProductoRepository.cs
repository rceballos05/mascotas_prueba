using Newtonsoft.Json.Linq;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Responses;
using SistemaVeterinario.Backend.Interfaces;
using SistemaVeterinario.Backend.Statics;

namespace SistemaVeterinario.Backend.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly HttpClient httpClient;
        public ProductoRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<dynamic> GetProducto(string token, string prefijo, string id)
        {
            try
            {
                ProductosDtoResponse lst = new();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/productos/{prefijo}/producto/{id}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        //Console.WriteLine(item);
                        lst = new ProductosDtoResponse { CodigoBarra = item.codigoBarra, Descripcion = item.descripcion, Precio = item.precio };
                    }
                }
                return lst;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }


        public async Task<BaseEntityResponsePaginated<ProductosDtoResponse>> GetProductoBusqueda(string token, string prefijo, string palabra, int page, int cantidadItems)
        {
            try
            {
                List<ProductosDtoResponse> lst = new();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/productos/{prefijo}/productos/{palabra}?Page={page}&ItemsPerPage={cantidadItems}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        //Console.WriteLine(item);
                        lst .Add( new ProductosDtoResponse { CodigoBarra = item.codigoBarra, Descripcion = item.descripcion, Precio = item.precio });
                    }
                }
                BaseEntityResponsePaginated<ProductosDtoResponse> responsePaginated = new();
                responsePaginated.Message = rsp.message;
                responsePaginated.StatusCode = rsp.statusCode;
                responsePaginated.TotalPages = rsp.totalPages;
                responsePaginated.TotalRecords = rsp.totalRecords;
                responsePaginated.Items = lst;
                return responsePaginated;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       

        public async Task<List<ProductosDtoResponse>> GetProductos(string token, string prefijo, int page, int cantidadItems)
        {
            try
            {
                List<ProductosDtoResponse> lst = new();
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/productos/{prefijo}/productos?Page={page}&ItemsPerPage={cantidadItems}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.items)
                    {
                        //Console.WriteLine(item);
                        lst.Add(new ProductosDtoResponse { CodigoBarra = item.codigoBarra, Descripcion = item.descripcion, Precio = item.precio });
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
