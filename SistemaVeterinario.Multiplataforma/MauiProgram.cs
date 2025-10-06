using Microsoft.Extensions.Logging;
using SistemaVeterinario.Backend.Interfaces;
using SistemaVeterinario.Backend.NavigationData;
using SistemaVeterinario.Backend.Repositories;

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
            builder.Services.AddSingleton<UserNavgationData>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://45.236.164.152:82/") });
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
