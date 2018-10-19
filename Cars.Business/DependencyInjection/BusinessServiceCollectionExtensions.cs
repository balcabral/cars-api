using Microsoft.Extensions.DependencyInjection;

namespace Cars.Business.DependencyInjection
{
	public static class BusinessServiceCollectionExtensions
    {
		public static IServiceCollection AddBussinessDependencyInjection(this IServiceCollection services)
        {
			services.AddTransient<ICarService, CarService>();
			return services;
        }
    }
}
