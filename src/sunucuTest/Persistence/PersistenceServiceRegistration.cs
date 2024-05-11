using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NArchitecture.Core.Persistence.DependencyInjection;
using Persistence.Contexts;
using Application.Services.Repositories;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var conString = configuration.GetConnectionString("DB");
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(conString));
        

        services.AddDbMigrationApplier(buildServices => buildServices.GetRequiredService<BaseDbContext>());


        services.AddScoped<IDenemeRepository, DenemeRepository>();
        return services;
    }
}
