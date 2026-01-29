using Microsoft.Extensions.Logging;

namespace EindExamenMaui
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //Repositories

            builder.Services.AddSingleton<DierRepository>();
            builder.Services.AddSingleton<SoortRepository>();
            builder.Services.AddSingleton<PersoonRepository>();

            //ViewModels
            builder.Services.AddSingleton<DierViewModel>();
            builder.Services.AddSingleton<EigenaarOverzichtViewModel>();

            //Views
            builder.Services.AddSingleton<DierPage>();
            builder.Services.AddSingleton<EigenaarOverzichtPage>();

            return builder.Build();
        }
    }
}
