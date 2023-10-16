using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Infrastructure.EF.Context;
using RestaurantChargoon.Infrastructure.EF.Repositories;
using RestaurantChargoon.Services.CommonServices;
using System.Reflection;

namespace Restaurant_Chargoon.UI.WinForm
{
	internal static class Program
	{
		public static User userLogin;
		public static int RestaurantId;
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			userLogin = new User();


			var types = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")
				.SelectMany(s => Assembly.LoadFrom(s).GetTypes())
				.Where(p => typeof(IDependencyRegistrar).IsAssignableFrom(p) && !p.IsInterface);


			var services = new ServiceCollection();
			foreach (var type in types)
				((IDependencyRegistrar)Activator.CreateInstance(type)).ConfigureServices(services);

			services.AddScoped<MainForm>();
			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				var mainForm = serviceProvider.GetRequiredService<MainForm>();
				Application.Run(mainForm);
			}

			//var services = new ServiceCollection();

			//ConfigureServices(services);

			//using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			//{
			//	var form1 = serviceProvider.GetRequiredService<MainForm>();
			//	Application.Run(form1);
			//}
		}

		public static void ConfigureServices(ServiceCollection services)
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
			services.AddScoped<MainForm>();
		}
	}
}