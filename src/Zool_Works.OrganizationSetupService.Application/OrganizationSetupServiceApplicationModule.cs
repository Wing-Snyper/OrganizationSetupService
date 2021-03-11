using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(OrganizationSetupServiceDomainModule),
        typeof(OrganizationSetupServiceApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class OrganizationSetupServiceApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<OrganizationSetupServiceApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<OrganizationSetupServiceApplicationModule>(validate: true);
            });
        }
    }
}
