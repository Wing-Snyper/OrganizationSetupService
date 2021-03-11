using Volo.Abp.Reflection;

namespace Zool_Works.OrganizationSetupService.Permissions
{
    public class OrganizationSetupServicePermissions
    {
        public const string GroupName = "OrganizationSetupService";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrganizationSetupServicePermissions));
        }
    }
}