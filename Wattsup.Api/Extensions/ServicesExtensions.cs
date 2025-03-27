using Wattsup.BLL.Services;
using Wattsup.BLL.Services.Base;
using Wattsup.BLL.Services.Base.Interfaces;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.DAL.Repositories;
using Wattsup.DAL.Repositories.Base;
using Wattsup.DAL.Repositories.Base.Interfaces;
using Wattsup.DAL.Repositories.Interfaces;

namespace Wattsup.Api.Extensions;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Generic registrations
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

        // Custom repositories and services
        services.AddScoped<IStoreRepository, StoreRepository>();
        services.AddScoped<IStoreService, StoreService>();

        services.AddScoped<IMeterRepository, MeterRepository>();
        services.AddScoped<IMeterService, MeterService>();

        services.AddScoped<IMeterReadingRepository, MeterReadingRepository>();
        services.AddScoped<IMeterReadingService, MeterReadingService>();

        return services;
    }

    public static IServiceCollection AddCorsPolicy(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            // pas de sécurité, tout le monde peut accèder à l'API.
            // utile pour le développement mais à NE PAS UTILISER EN PRODUCTION
            options.AddPolicy("FFA", policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyMethod();
                policy.AllowAnyHeader();
            });

            // Configuration de sécurité pour le développement
            // uniquement les clients avec ces URLs spécifiques peuvent accèder à l'API
            options.AddPolicy("Dev", policy =>
            {
                policy.WithOrigins("http://localhost:63342", "http://demo.be");
                policy.AllowAnyMethod();
                policy.AllowAnyHeader();
            });
        });
        return services;
    }
}
