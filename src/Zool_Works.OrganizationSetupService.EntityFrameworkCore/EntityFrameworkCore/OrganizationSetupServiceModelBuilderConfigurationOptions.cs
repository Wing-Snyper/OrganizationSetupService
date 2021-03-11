using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Zool_Works.OrganizationSetupService.EntityFrameworkCore
{
    public class OrganizationSetupServiceModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public OrganizationSetupServiceModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}