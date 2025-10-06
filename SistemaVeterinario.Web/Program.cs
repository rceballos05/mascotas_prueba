using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using SistemaVeterinario.Backend.Interfaces;
using SistemaVeterinario.Backend.NavigationData;
using SistemaVeterinario.Backend.Repositories;
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
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://45.236.164.152:82/") }); //VPN
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://192.168.1.2:88/") }); //oficina
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://10.32.64.8:88/") }); // CASA
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
