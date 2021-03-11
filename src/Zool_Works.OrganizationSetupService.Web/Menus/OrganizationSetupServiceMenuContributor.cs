using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Zool_Works.OrganizationSetupService.Web.Menus
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

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(OrganizationSetupServiceMenus.Prefix, displayName: "OrganizationSetupService", "~/OrganizationSetupService", icon: "fa fa-globe"));
            
            return Task.CompletedTask;
        }
    }
}