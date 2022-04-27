using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Data.Database;
using Business.Logic;
using Microsoft.EntityFrameworkCore;

namespace UI.Desktop
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

                services.AddSingleton<frmMain>();
                services.AddDbContext<LavanderiaContext>(opt =>
                {
                    //opt.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnStringLocal"].ConnectionString);
                    opt.UseSqlServer(configuration.GetConnectionString("ConnStringLocal"));
                });
            }).Build();
            using (var services = host.Services.CreateScope())
            {
                var dbContext = services.ServiceProvider.GetRequiredService<LavanderiaContext>();
                

                var frmMain = services.ServiceProvider.GetRequiredService<frmMain>();
                Application.Run(frmMain);
            }
            
        }
    }
}
