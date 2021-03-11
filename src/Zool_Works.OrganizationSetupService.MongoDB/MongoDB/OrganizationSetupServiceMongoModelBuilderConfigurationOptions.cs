using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Zool_Works.OrganizationSetupService.MongoDB
{
    public class OrganizationSetupServiceMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public OrganizationSetupServiceMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}