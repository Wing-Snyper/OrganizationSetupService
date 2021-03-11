using Zool_Works.OrganizationSetupService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Zool_Works.OrganizationSetupService.Permissions
{
    public class OrganizationSetupServicePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(OrganizationSetupServicePermissions.GroupName, L("Permission:OrganizationSetupService"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OrganizationSetupServiceResource>(name);
        }
    }
}