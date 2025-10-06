using System.Net;
using Microsoft.Extensions.Logging;
using SistemaVeterinario.Backend.Interfaces;
using SistemaVeterinario.Backend.NavigationData;
using SistemaVeterinario.Backend.Repositories;
using SistemaVeterinario.Backend.Statics;

namespace SistemaVeterinario.Multiplataforma
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Configuration
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

            var apiBaseUrl = builder.Configuration["Api:BaseUrl"];

            builder.Services.AddSingleton<UserNavgationData>();
            builder.Services.AddHttpClient(HttpClientNames.Api, client =>
            {
                if (!string.IsNullOrWhiteSpace(apiBaseUrl) && Uri.TryCreate(apiBaseUrl, UriKind.Absolute, out var baseUri))
                {
                    client.BaseAddress = baseUri;
                }
                else
                {
                    client.BaseAddress = new Uri("https://localhost:7218/");
                }

                client.DefaultRequestVersion = HttpVersion.Version20;
                client.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrHigher;
            });
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient(HttpClientNames.Api));
            builder.Services.AddScoped<ILoginRepository, LoginRepository>();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
                builder.Services.AddBlazorWebViewDeveloperTools();
                builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
