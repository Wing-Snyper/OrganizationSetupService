using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(OrganizationSetupServiceDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class OrganizationSetupServiceApplicationContractsModule : AbpModule
    {

    }
}
