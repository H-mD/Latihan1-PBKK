using Microsoft.Extensions.Logging;

namespace pertemuan_07
{
    public static class MauiProgram
    {
        public static MauiProgram CreateMauiApp()
        {
            var builder = MauiProgram.CreateBuilder();
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

            return builder.Build();
        }
    }
}