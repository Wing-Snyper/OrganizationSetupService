using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Zool_Works.OrganizationSetupService.EntityFrameworkCore
{
    public class OrganizationSetupServiceHttpApiHostMigrationsDbContext : AbpDbContext<OrganizationSetupServiceHttpApiHostMigrationsDbContext>
    {
        public OrganizationSetupServiceHttpApiHostMigrationsDbContext(DbContextOptions<OrganizationSetupServiceHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureOrganizationSetupService();
            modelBuilder.ConfigureAuditLogging();
            modelBuilder.ConfigurePermissionManagement();
            modelBuilder.ConfigureSettingManagement();
        }
    }
}
