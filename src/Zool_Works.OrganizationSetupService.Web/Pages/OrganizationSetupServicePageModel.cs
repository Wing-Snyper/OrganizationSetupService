using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Zool_Works.OrganizationSetupService.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class OrganizationSetupServicePageModel : AbpPageModel
    {
        protected OrganizationSetupServicePageModel()
        {
            LocalizationResourceType = typeof(OrganizationSetupServiceResource);
            ObjectMapperContext = typeof(OrganizationSetupServiceWebModule);
        }
    }
}