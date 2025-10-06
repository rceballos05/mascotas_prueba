using Newtonsoft.Json.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using SistemaVeterinario.Backend.Entities.Dtos;
using SistemaVeterinario.Backend.Entities.Models;
using SistemaVeterinario.Backend.Entities.Requests;
using SistemaVeterinario.Backend.Entities.Responses;
using SistemaVeterinario.Backend.Interfaces;
using System.Text;
using System.Text.Json;

namespace SistemaVeterinario.Backend.Repositories
{
    public class VentasRepository : IVentaRepository
    {
        private readonly HttpClient httpClient;
        public VentasRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public byte[] GenerarDocumento(MascotasDto mascotaDtoRequest,Propietario propietario, LocalVentaCabezaDto cabeza01, VentaDetalleDtoRequest detalleDtoRequest)
        {
          //  var logo = Placeholders.Image(60, 60); // Aquí puedes poner tu logo real con .Image("ruta")

            var pdfBytes = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(40);

                    // Encabezado
                    page.Header().Row(row =>
                    {
                        //row.ConstantItem(80).Image(logo);
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("").FontSize(16).Bold();
                            col.Item().Text("RUT: 12.345.678-9");
                            col.Item().Text("Av. Principal 123, Santiago, Chile");
                            col.Item().Text("Tel: +56 9 1234 5678");
                        });
                        row.ConstantItem(120).Column(col =>
                        {
                            col.Item().Border(1).Padding(5).AlignCenter().Text("FACTURA").FontSize(14).Bold();
                            col.Item().Border(1).Padding(5).AlignCenter().Text("N° 000123");
                            col.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy}");
                        });
                    });

                    page.Content().PaddingVertical(10).Column(col =>
                    {
                        // Datos cliente
                        col.Item().Text($"Cliente: {propietario.Nombre}").Bold();
                        col.Item().Text($"RUT: {propietario.Rut}");
                        col.Item().Text($"Dirección: {propietario.Direccion}");

                        col.Item().PaddingTop(15);

                        // Tabla de detalle
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(4); // Producto
                                columns.RelativeColumn(1); // Cantidad
                                columns.RelativeColumn(2); // Precio
                                columns.RelativeColumn(2); // Total
                            });

                            // Encabezados
                            table.Header(header =>
                            {
                                header.Cell().Text("Producto").Bold();
                                header.Cell().Text("Cant.").Bold();
                                header.Cell().Text("Precio").Bold();
                                header.Cell().Text("Total").Bold();
                            });

                            // Filas desde tu detalleDtoRequest
                            foreach (var item in detalleDtoRequest.Ventas)
                            {
                                table.Cell().Text(item.ArtDescripcion);
                                table.Cell().Text(item.ArtCantidad.ToString());
                                table.Cell().Text(item.ArtPrecio.ToString("C0"));
                                table.Cell().Text(item.TotalLinea.ToString("C0"));
                            }
                        });

                        col.Item().PaddingTop(20).AlignRight().Column(sum =>
                        {
                            sum.Item().Text($"Subtotal: {cabeza01.Subtotal:C0}").FontSize(12);
                            sum.Item().Text($"IVA (19%): {cabeza01.MontoIva:C0}").FontSize(12);
                            sum.Item().Text($"Total: {cabeza01.MontoTotal:C0}").FontSize(14).Bold();
                        });
                    });

                    page.Footer().AlignCenter().Text("Gracias por su compra").FontSize(10);
                });
            }).GeneratePdf();

            return pdfBytes;
        }

        public async Task<List<HistorialDtoResponse>> GetHistorial(string token, string prefijo, string local, string numero, string caja)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/ventas/{prefijo}/{local}/{caja}/obtener-historial/{numero}");
                var responseString = await response.Content.ReadAsStringAsync();
                List<HistorialDtoResponse> lst = new List<HistorialDtoResponse>();
                dynamic rsp = JObject.Parse(responseString);
                if (rsp.statusCode == 200)
                {
                    foreach (var item in rsp.Items) {
                        lst.Add(new HistorialDtoResponse {
                            Codigo = item.codigo,
                            Descripcion = item.descripcion,
                            Fecha = item.fecha,
                        });
                    }
                }
                
                return lst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<string> GetNumeroPreventa(string token, string prefijo, string local, string caja)
        {
            try
            {
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.GetAsync($"api/ventas/{prefijo}/{local}/numero-venta/{caja}");
                var responseString = await response.Content.ReadAsStringAsync();
                var numero = "";
                dynamic rsp = JObject.Parse(responseString);
                if (rsp.statusCode == 200)
                {
                    int num = Convert.ToInt32(rsp.items[0]) + 1;
                    numero = num.ToString();
                }
                else if(rsp.statusCode == 400)
                {
                    numero = "1";
                }
                    return numero;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> GetVenta(string token, string prefijo, string local, string caja,string tipo, string numero)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/ventas/{prefijo}/{local}/{caja}/obtener-venta/{tipo}/{numero}");
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 200)
                {
                    return true;
                }
                return rsp;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> PostVentaCabeza(string token, string prefijo, string local, LocalVentaCabezaDto request)
        {
            try
            {
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/ventas/{prefijo}/{local}/ingresar-venta-cabeza", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 201)
                {
                    return true;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> PostVentaDetalle(string token, string prefijo, string local, List<LocalVentaDetalleDto> request)
        {
            try
            {
                var json = JsonSerializer.Serialize(request);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/ventas/{prefijo}/{local}/ingresar-venta-detalle", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 201)
                {
                    return true;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<dynamic> PostVentaObservaciones(string token, string prefijo, string local, LocalVentaObservaciones01 observaciones01)
        {
            try
            {
                var json = JsonSerializer.Serialize(observaciones01);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await httpClient.PostAsync($"api/ventas/{prefijo}/{local}/ingresar-venta-cabeza", content);
                var responseString = await response.Content.ReadAsStringAsync();

                dynamic rsp = JObject.Parse(responseString);

                if (rsp.statusCode == 201)
                {
                    return true;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
