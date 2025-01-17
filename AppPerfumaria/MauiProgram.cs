using AppPerfumaria.Services;
using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using MudBlazor.Services;
using ZXing.Net.Maui.Controls;

namespace AppPerfumaria
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
                })
                .UseBarcodeReader();


            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddSingleton<Carrinho>();


            // Registre MainPage como um serviço singleton ou transitório
            builder.Services.AddSingleton<MainPage>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddMudServices();

            return builder.Build();
        }
    }
}
