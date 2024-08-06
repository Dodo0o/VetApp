using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using VetApp.Services;
using VetApp.Forms;
using VetApp.Models;

namespace VetApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

            var services = new ServiceCollection();
            services.AddDbContext<VetAppContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("VetAppDB")));

            // Add services
            services.AddTransient<MusteriService>();
            services.AddTransient<HayvanService>();
            services.AddTransient<RandevuService>();
            services.AddTransient<GirisService>();
            services.AddTransient<AsiService>(); // Add AsiService
            services.AddTransient<TibbiKayitService>(); // Add TibbiKayitService

            // Add forms
            services.AddTransient<MusteriEkleForm>();
            services.AddTransient<MusteriListeForm>();
            services.AddTransient<HayvanEkleForm>();
            services.AddTransient<HayvanListeForm>();
            services.AddTransient<RandevuEkleForm>();
            services.AddTransient<RandevuDuzenleForm>();
            services.AddTransient<RandevuListeForm>();
            services.AddTransient<VeterinerForm>();
            services.AddTransient<KarsilamaForm>();
            services.AddTransient<MusteriGirisForm>();
            services.AddTransient<VeterinerGirisForm>();
            services.AddTransient<HayvanDuzenleForm>();
            services.AddTransient<HayvanSilForm>();
            services.AddTransient<MusteriDuzenleForm>();
            services.AddTransient<MusteriSilForm>();

            // Add Func<int, MusteriForm> registration
            services.AddTransient<Func<int, MusteriForm>>(provider => musteriId =>
                new MusteriForm(
                    provider.GetRequiredService<HayvanService>(),
                    provider.GetRequiredService<TibbiKayitService>(), // Add TibbiKayitService
                    provider.GetRequiredService<AsiService>(), // Add AsiService
                    provider.GetRequiredService<MusteriService>(),
                    musteriId));

            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<KarsilamaForm>());
        }
    }
}
