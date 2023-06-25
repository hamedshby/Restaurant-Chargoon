using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantChargoon.Domain.Contracts;
using RestaurantChargoon.Domain.DataModels;
using RestaurantChargoon.Infrastructure.EF.Context;
using RestaurantChargoon.UI.WinForm.Resources;
using RestaurantChargoon.UI.WinForm.Services;
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

            //var optionsBuilder = new DbContextOptionsBuilder<RestaurantDbContext>();
            //optionsBuilder.UseSqlServer("server=.;initial catalog=Restaurant;integrated security=true;TrustServerCertificate=True");

            Application.ThreadException += new ThreadExceptionEventHandler(ExceptionHandler);

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
        }

        static void ExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            FormService.ShowErrorMessageBox(Resource.ErrorMessage);
            using var writer = new StreamWriter(@"..\..\..\..\log.txt", true);
            writer.WriteLine(DateTime.Now.ToShortDateString() + "\t"
                + DateTime.Now.ToShortTimeString() + "\t"
                + e.Exception.Message);
        }
    }
}