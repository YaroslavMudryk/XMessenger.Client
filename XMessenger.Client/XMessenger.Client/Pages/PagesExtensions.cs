namespace XMessenger.Client.Pages;

public static class PagesExtensions
{
    public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
    {
        // main tabs of the app
        builder.Services.AddSingleton<ProfilePage>();
        builder.Services.AddSingleton<SettingsPage>();

        // pages that are navigated to
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<SearchPage>();

        return builder;
    }
}