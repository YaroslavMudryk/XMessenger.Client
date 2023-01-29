using Microsoft.Extensions.DependencyInjection.Extensions;

namespace XMessenger.Client.Services
{
    public static class ServiceExtensions
    {
        public static MauiAppBuilder ConfigureServices(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient(_ => Connectivity.Current);
            builder.Services.TryAddTransient<InternetAccessService>();
            return builder;
        }
    }
}
