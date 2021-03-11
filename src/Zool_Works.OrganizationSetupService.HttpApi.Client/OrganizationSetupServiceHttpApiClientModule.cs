using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(OrganizationSetupServiceApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class OrganizationSetupServiceHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "OrganizationSetupService";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrganizationSetupServiceApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
