using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Infrastructure.EF.Context;
using RestaurantChargoon.Infrastructure.EF.Repositories;

namespace RestaurantChargoon.Services.CommonServices
{
	public class DependencyRegitrar : IDependencyRegistrar
	{
		public void ConfigureServices(ServiceCollection services)
		{
			services.AddDbContext<RestaurantDbContext>(c =>
			{
				c.UseSqlServer("server=.;initial catalog=Restaurant;integrated security=true;TrustServerCertificate=True");
				c.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			});
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped(typeof(IFactorDetailRepository), typeof(FactorDetailRepository));
			services.AddScoped(typeof(IFactorRepository), typeof(FactorRepository));
			services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
			services.AddScoped(typeof(IRestaurantRepository), typeof(RestaurantRepository));
			services.AddScoped(typeof(IFoodRepository), typeof(FoodRepository));
		}
	}
}
