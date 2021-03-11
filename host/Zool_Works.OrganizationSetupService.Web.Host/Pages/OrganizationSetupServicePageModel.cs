using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Zool_Works.OrganizationSetupService.Pages
{
    public abstract class OrganizationSetupServicePageModel : AbpPageModel
    {
        protected OrganizationSetupServicePageModel()
        {
            LocalizationResourceType = typeof(OrganizationSetupServiceResource);
        }
    }
}