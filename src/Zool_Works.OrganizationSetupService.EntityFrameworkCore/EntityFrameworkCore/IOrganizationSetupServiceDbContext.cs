using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Zool_Works.OrganizationSetupService.Organizations;

namespace Zool_Works.OrganizationSetupService.EntityFrameworkCore
{
    [ConnectionStringName(OrganizationSetupServiceDbProperties.ConnectionStringName)]
    public interface IOrganizationSetupServiceDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Organization> Organizations { get; set; }
    }
}