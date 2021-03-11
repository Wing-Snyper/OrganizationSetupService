using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Zool_Works.OrganizationSetupService.Organizations;

namespace Zool_Works.OrganizationSetupService.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class OrganizationSetupServiceDbContext : AbpDbContext<OrganizationSetupServiceDbContext>
    {

        public DbSet<Organization> Organizations { get; set; }
        //map the dbset entities or agg roots inside OrgSetupSrvcDbContextModelCreatingExtensions.ConfigureOrganizationSetupService

        public OrganizationSetupServiceDbContext(DbContextOptions<OrganizationSetupServiceDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            /* Configure your own tables/entities inside the ConfigureBookStore method */

            builder.ConfigureOrganizationSetupService();
        }
    }
}