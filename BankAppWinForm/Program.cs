using BankApp.Data;
using BankApp.Implementations;
using BankApp.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BankAppWinForm
{
    internal static class Program
    {
        public static IServiceProvider? _serviceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            _serviceProvider = host.Services.GetRequiredService<IServiceProvider>();
            Application.Run(_serviceProvider.GetRequiredService<Login>());
            //Application.Run(_serviceProvider.GetRequiredService<Register>());

        }

        static IHostBuilder CreateHostBuilder()
        {
            
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddScoped<IValidation, Validation>();
                    services.AddScoped<ICustomerData, CustomerData>();
                    services.AddScoped<IAccountData, AccountData>();
                    services.AddScoped<ICustomer, Customer>();
                    services.AddTransient<IAccount, Account>();
                    services.AddTransient<IBank, Bank>();
                    services.AddTransient<Login>();
                    services.AddTransient<Register>();
                });
        }
    }
}