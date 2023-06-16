using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Infrastructure.EF.Context;
using RestaurantChargoon.Infrastructure.EF.Repositories;
using RestaurantChargoon.Services.CommonServices;
using RestaurantChargoon.UI.WinForm.Forms;
using System.Configuration;
using Unity;

namespace Restaurant_Chargoon.UI.WinForm
{
	internal static class Program
    {
		private static IUnityContainer container;
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

			//container = new UnityContainer();
			//container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			//container.RegisterType(typeof(IUnitOfWork), typeof(UnitOfWork));
			//container.RegisterType(typeof(IFactorDetailRepository), typeof(FactorDetailRepository));
			//Application.Run(container.Resolve<SingupUserForm>());

			userLogin = new User();

			//var optionsBuilder = new DbContextOptionsBuilder<RestaurantDbContext>();
			//optionsBuilder.UseSqlServer("server=.;initial catalog=Restaurant;integrated security=true;TrustServerCertificate=True");

			var services = new ServiceCollection();

			ConfigureServices(services);

			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				var form1 = serviceProvider.GetRequiredService<MainForm>();
				Application.Run(form1);
			}
        }

		private static void ConfigureServices(ServiceCollection services)
		{			
			services.AddDbContext<RestaurantDbContext>(c => c.UseSqlServer("server=.;initial catalog=Restaurant;integrated security=true;TrustServerCertificate=True"));
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddTransient(typeof(IFactorDetailRepository), typeof(FactorDetailRepository));
			services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
			services.AddScoped<MainForm>();
		}
	}


}