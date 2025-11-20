using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class ApplicationServiceRegistiration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()); // Git bütün assambly i tara orda commendleri queryleri bul onları handlerları ile eşle ben sana commandSend yaparsam çalıştır.
        });

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}
