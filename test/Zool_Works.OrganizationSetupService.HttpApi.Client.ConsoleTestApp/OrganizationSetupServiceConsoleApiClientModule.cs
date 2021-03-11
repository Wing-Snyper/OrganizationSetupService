using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(OrganizationSetupServiceHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OrganizationSetupServiceConsoleApiClientModule : AbpModule
    {
        
    }
}
