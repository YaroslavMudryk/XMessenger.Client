namespace XMessenger.Client.ViewModels
{
    public static class ViewModelExtensions
    {
        public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<SettingsViewModel>();
            builder.Services.AddSingleton<ShellViewModel>();

            builder.Services.AddScoped<LoginViewModel>();

            return builder;
        }
    }
}
