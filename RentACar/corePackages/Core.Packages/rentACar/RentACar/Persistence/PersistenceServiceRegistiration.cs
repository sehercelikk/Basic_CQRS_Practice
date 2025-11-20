using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistiration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<BaseDbContext>(opt=>
        {
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
        });

        service.AddScoped<IBrandReposiory, BrandRepository>();
        return service;
    }
}
