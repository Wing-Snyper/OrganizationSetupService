using System.Threading.Tasks;
using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.UI.Navigation;

namespace Zool_Works.OrganizationSetupService.Blazor.Host
{
    public class OrganizationSetupServiceHostMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<OrganizationSetupServiceResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "OrganizationSetupService.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
