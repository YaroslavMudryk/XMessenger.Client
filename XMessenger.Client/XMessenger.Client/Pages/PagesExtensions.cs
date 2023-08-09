namespace XMessenger.Client.Pages;

public static class PagesExtensions
{
    public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
    {
        // main tabs of the app
        builder.Services.AddSingleton<ProfilePage>();
        builder.Services.AddSingleton<SettingsPage>();

        // pages that are navigated to
        builder.Services.AddScoped<LoginPage>();
        builder.Services.AddScoped<SearchPage>();

        return builder;
    }
}