using Zool_Works.OrganizationSetupService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Zool_Works.OrganizationSetupService
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OrganizationSetupServiceEntityFrameworkCoreTestModule)
        )]
    public class OrganizationSetupServiceDomainTestModule : AbpModule
    {
        
    }
}
