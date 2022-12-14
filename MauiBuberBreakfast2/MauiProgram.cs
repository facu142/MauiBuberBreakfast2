using CommunityToolkit.Maui;

namespace MauiBuberBreakfast2;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
            fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
        }).UseMauiCommunityToolkit();
        return builder.Build();
    }
}