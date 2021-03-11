using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Zool_Works.OrganizationSetupService.EntityFrameworkCore
{
    public class OrganizationSetupServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<OrganizationSetupServiceHttpApiHostMigrationsDbContext>
    {
        public OrganizationSetupServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OrganizationSetupServiceHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("OrganizationSetupService"));

            return new OrganizationSetupServiceHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
