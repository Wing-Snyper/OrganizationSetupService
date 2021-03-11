using Volo.Abp.Modularity;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(OrganizationSetupServiceApplicationModule),
        typeof(OrganizationSetupServiceDomainTestModule)
        )]
    public class OrganizationSetupServiceApplicationTestModule : AbpModule
    {

    }
}
