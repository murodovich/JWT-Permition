using JWT.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JWT.Infrastructure;
public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<JWTDbContext, JWTDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Defoult"));
        });

        return services;
    }
}
