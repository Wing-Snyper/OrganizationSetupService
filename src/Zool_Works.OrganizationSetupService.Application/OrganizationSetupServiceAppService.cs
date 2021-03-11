using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.Application.Services;

namespace Zool_Works.OrganizationSetupService
{
    public abstract class OrganizationSetupServiceAppService : ApplicationService
    {
        protected OrganizationSetupServiceAppService()
        {
            LocalizationResource = typeof(OrganizationSetupServiceResource);
            ObjectMapperContext = typeof(OrganizationSetupServiceApplicationModule);
        }
    }
}
