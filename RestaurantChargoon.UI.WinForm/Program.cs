using RestaurantChargoon.Domain.Repositories;
using RestaurantChargoon.Infrastructure.EF.Repositories;
using Unity;

namespace Restaurant_Chargoon.UI.WinForm
{
    internal static class Program
    {
		private static IUnityContainer container;
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

			container = new UnityContainer();
			container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));			
			Application.Run(container.Resolve<MainForm>());


			//Application.Run(new MainForm());
        }
    }
}