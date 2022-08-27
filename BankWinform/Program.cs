using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using BankAppCore;
using BankAppCore.Services;
using BankAppCore.Helper;
using BankAppUI;

namespace BankWinform
{
    static class Program
    {
        public static IServiceProvider serviceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var service = new ServiceCollection();
            ConfigureServices(service);

            using (ServiceProvider serviceProvider= service.BuildServiceProvider())
            {
                var welcome = serviceProvider.GetRequiredService<Welcome>();
                Application.Run(welcome);
            }
        }
        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUserService, UserService> ();
            services.AddScoped<IReadWriteJson, ReadWriteJson>();
            services.AddScoped<IValidator, Validator>();
            services.AddScoped<IUtilities, Utilities>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAccount, Account>();
            services.AddScoped<IBank, Bank>();
            services.AddScoped<Welcome>();
            services.AddScoped<SignUp>();
            services.AddScoped<Login>();
            services.AddScoped<DashBoard>();
        }
    }
}
