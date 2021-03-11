using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Zool_Works.OrganizationSetupService
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class OrganizationSetupServiceDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<OrganizationSetupServiceDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<OrganizationSetupServiceResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/OrganizationSetupService");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("OrganizationSetupService", typeof(OrganizationSetupServiceResource));
            });
        }
    }
}
