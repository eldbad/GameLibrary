using GameLibrary.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GameLibrary.Application;

public static class ConfigureServices
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<GameService>();
    }
}