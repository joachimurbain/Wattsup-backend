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

		return services;
	}
}
