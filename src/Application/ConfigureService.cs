using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitectureImplementation.Application;
public static class ConfigureService
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(ctg => {
            ctg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}