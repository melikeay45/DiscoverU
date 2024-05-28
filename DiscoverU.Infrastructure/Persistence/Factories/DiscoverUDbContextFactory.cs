using DiscoverU.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DiscoverU.Infrastructure.Persistence.Factories
{
    public class DiscoverUDbContextFactory : IDesignTimeDbContextFactory<DiscoverUDbContext>
    {
        public DiscoverUDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DiscoverUDbContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
             .SetBasePath($"{Directory.GetParent(Directory.GetCurrentDirectory())}/DiscoveryU.Infrastructure")
             .AddJsonFile("appsettings.json")
             .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("PostgreSQL");

            // Configure the DbContext to use PostgreSQL
            optionsBuilder.UseNpgsql(connectionString);

            return new DiscoverUDbContext(optionsBuilder.Options);
        }
    }
}