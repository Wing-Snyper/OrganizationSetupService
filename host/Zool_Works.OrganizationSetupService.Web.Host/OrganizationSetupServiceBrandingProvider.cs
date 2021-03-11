using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Zool_Works.OrganizationSetupService
{
    [Dependency(ReplaceServices = true)]
    public class OrganizationSetupServiceBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "OrganizationSetupService";
    }
}
