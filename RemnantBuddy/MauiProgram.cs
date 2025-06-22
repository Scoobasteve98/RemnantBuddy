using Microsoft.Extensions.Logging;
using RemnantBuddy.Data;
using RemnantBuddy.Models;
using RemnantBuddy.Views;

namespace RemnantBuddy;

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

        builder.Services.AddDbContextFactory<RemnantDbContext>();
        builder.Services.AddSingleton<RemnantRepository>();
        builder.Services.AddSingleton<RingsList>();
        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddTransient<EditItem>();
        builder.Services.AddTransient<ViewItem>();
        builder.Services.AddTransient<ItemList>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
