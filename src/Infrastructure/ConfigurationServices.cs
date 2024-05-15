using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CleanArchitectureImplementation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using CleanArchitectureImplementation.Domain.Repository;
using CleanArchitectureImplementation.Infrastructure.Repositories;

namespace CleanArchitectureImplementation.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => 
        {
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection") ?? 
                throw new InvalidOperationException("Connections string 'AppDbContext' not found"));
        });
        services.AddTransient<IUsersRepository, UserRepository>();
        return services; 
    }
}