using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace VetApp.Models
{
    public class VetAppContextFactory : IDesignTimeDbContextFactory<VetAppContext>
    {
        public VetAppContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<VetAppContext>();
            var connectionString = configuration.GetConnectionString("VetAppDB");

            builder.UseSqlServer(connectionString);

            return new VetAppContext(builder.Options);
        }
    }
}
