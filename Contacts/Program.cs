using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Repository;
using Shared.Interfaces.Business;
using DataAccessLayer.Repositories;
using System;
using BusinessLayer.Businesses;
using System.Windows.Forms;
using MainMenu = Contacts.Forms.MainMenu;

namespace Contacts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainMenu>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
           services.AddSingleton<IPersonRepository, PersonRepository>();
           services.AddScoped<IPersonBusiness, PersonBusiness>();
           services.AddScoped<MainMenu>();
        }
    }
}
