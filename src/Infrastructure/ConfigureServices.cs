using GameLibrary.Application.Common;
using GameLibrary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameLibrary.Infrastructure;

public static class ConfigureServices
{
    public static void ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionPassword = configuration["GameLibrary:ConnectionString"];
        var connection = configuration.GetConnectionString("Default");
        services.AddDbContext<IAppDbContext, AppDbContext>(
            options => options.UseMySql(
                connection + connectionPassword,
                new MySqlServerVersion(new Version(11, 0, 2))
            )
        );
        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}