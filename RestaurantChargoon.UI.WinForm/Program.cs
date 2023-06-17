using Microsoft.EntityFrameworkCore;
using RestaurantChargoon.Domain.Entities;
using RestaurantChargoon.Infrastructure.EF.Context;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;

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

			var optionsBuilder = new DbContextOptionsBuilder<RestaurantDbContext>();
			optionsBuilder.UseSqlServer("server=.;initial catalog=Restaurant;integrated security=true;TrustServerCertificate=True");

			Application.ThreadException += new ThreadExceptionEventHandler(ExceptionHandler);

			Application.Run(new MainForm());
		}

		static void ExceptionHandler(object sender, ThreadExceptionEventArgs e)
		{
			FormService.ShowErrorMessageBox(Resource.ErrorMessage);
			using var writer = new StreamWriter(@"..\..\..\log.txt", true);
			writer.WriteLine(DateTime.Now.ToShortDateString() + "\t"
				+ DateTime.Now.ToShortTimeString() + "\t"
				+ e.Exception.Message);
		}
	}
}