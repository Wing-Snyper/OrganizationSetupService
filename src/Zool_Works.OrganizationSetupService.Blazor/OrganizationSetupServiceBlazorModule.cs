using Microsoft.Extensions.DependencyInjection;
using Zool_Works.OrganizationSetupService.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Zool_Works.OrganizationSetupService.Blazor
{
    [DependsOn(
        typeof(OrganizationSetupServiceHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule),
        typeof(AbpAutoMapperModule)
        )]
    public class OrganizationSetupServiceBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<OrganizationSetupServiceBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<OrganizationSetupServiceBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new OrganizationSetupServiceMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(OrganizationSetupServiceBlazorModule).Assembly);
            });
        }
    }
}