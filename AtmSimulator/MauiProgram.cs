using AtmSimulator.AppSettings;
using AtmSimulator.ViewModels;
using AtmSimulator.Views;
using Microsoft.Extensions.Logging;

namespace AtmSimulator;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<AppSettings.AppSettings>();
        //Store
        builder.Services.AddSingleton<MainStore>();

        builder.Services.AddSingleton<MainView>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<AdminView>();
        builder.Services.AddSingleton<AdminViewModel>();
        builder.Services.AddSingleton<AdminLoginView>();
        builder.Services.AddSingleton<AdminLoginViewModel>();

        return builder.Build();
    }
}