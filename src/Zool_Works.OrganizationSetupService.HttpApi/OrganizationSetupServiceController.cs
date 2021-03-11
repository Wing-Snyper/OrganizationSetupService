using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Zool_Works.OrganizationSetupService
{
    public abstract class OrganizationSetupServiceController : AbpController
    {
        protected OrganizationSetupServiceController()
        {
            LocalizationResource = typeof(OrganizationSetupServiceResource);
        }
    }
}
