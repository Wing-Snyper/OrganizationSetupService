using Localization.Resources.AbpUi;
using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(OrganizationSetupServiceApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class OrganizationSetupServiceHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(OrganizationSetupServiceHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<OrganizationSetupServiceResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
