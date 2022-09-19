namespace sqliteDemo;

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
        // 下記を追加
        string dbPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, "people.db3");
        builder . Services . AddSingleton<DemoTblRepository> ( s => ActivatorUtilities . CreateInstance<DemoTblRepository> ( s , dbPath ) );

        return builder .Build();
    }
}
