using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(OrganizationSetupServiceDomainSharedModule)
    )]
    public class OrganizationSetupServiceDomainModule : AbpModule
    {

    }
}
