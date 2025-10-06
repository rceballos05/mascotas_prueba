using System.Net;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using SistemaVeterinario.Backend.Interfaces;
using SistemaVeterinario.Backend.NavigationData;
using SistemaVeterinario.Backend.Repositories;
using SistemaVeterinario.Backend.Statics;
using SistemaVeterinario.Web;
using SistemaVeterinario.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddRadzenComponents();
builder.Services.AddScoped<DialogService>();
builder.Services.AddSingleton<UserNavgationData>();
builder.Services.AddSingleton<MascotaNavigationData>();
builder.Services.AddSingleton<EmpresaSeleccionadaNavigationData>();
var apiBaseUrl = builder.Configuration["Api:BaseUrl"];
builder.Services.AddHttpClient(HttpClientNames.Api, client =>
{
    if (!string.IsNullOrWhiteSpace(apiBaseUrl) && Uri.TryCreate(apiBaseUrl, UriKind.Absolute, out var baseUri))
    {
        client.BaseAddress = baseUri;
    }
    else
    {
        client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
    }

    client.DefaultRequestVersion = HttpVersion.Version20;
    client.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrHigher;
});
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient(HttpClientNames.Api));
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ArchivosService>();
builder.Services.AddScoped<IAyudaRepository, AyudaRepository>();
builder.Services.AddScoped<IPropietarioRepository, PropietarioRepository>();
builder.Services.AddScoped<IMascotaRepository, MascotaRepository>();
builder.Services.AddScoped<IConsultasRepository, ConsultasRepository>();
builder.Services.AddScoped<IControlesRepository, ControlesRepository>();
builder.Services.AddScoped<IEspecieRepository, EspecieRepository>();
builder.Services.AddScoped<IEstadoReproductivoRepository, EstadoReproductivoRepository>();
builder.Services.AddScoped<IRazaRepository, RazaRepository>();
builder.Services.AddScoped<ISexoRepository, SexoRepository>();
builder.Services.AddScoped<IEstadoRepository, EstadoRepository>();
builder.Services.AddScoped<IComunasRepository, ComunasRepository>();
builder.Services.AddScoped<IRecetasRepository, RecetasRepository>();
builder.Services.AddScoped<IHospitalizacionesRepository, HospitalizacionesRepository>();
builder.Services.AddScoped<IMascotasFotosRepository, MascotasFotosRepository>();
builder.Services.AddScoped<IColorRepository, ColorRepository>();
builder.Services.AddScoped<ICentroCostoRepository, CentroCostoRepository>();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IVentaRepository, VentasRepository>();
builder.Services.AddScoped<IDatosTributariosRepository, DatosTributariosRepository>();
builder.Services.AddScoped<IEspecialistaRepository, EspecialistaRepository>();
builder.Services.AddScoped<IAuditoriaRepository, AuditoriaRepository>();


builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();
