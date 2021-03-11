using System.Threading.Tasks;
using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.UI.Navigation;

namespace Zool_Works.OrganizationSetupService.Blazor.Menus
{
    public class OrganizationSetupServiceMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private static async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            var l = context.GetLocalizer<OrganizationSetupServiceResource>();
            
            context.Menu.AddItem(new ApplicationMenuItem(OrganizationSetupServiceMenus.Prefix, displayName: "OrganizationSetupService", "/OrganizationSetupService", icon: "fa fa-globe"));
            
            await Task.CompletedTask;
        }
    }
}