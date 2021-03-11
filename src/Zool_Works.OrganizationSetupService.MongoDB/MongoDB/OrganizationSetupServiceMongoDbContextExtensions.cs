using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Zool_Works.OrganizationSetupService.MongoDB
{
    public static class OrganizationSetupServiceMongoDbContextExtensions
    {
        public static void ConfigureOrganizationSetupService(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrganizationSetupServiceMongoModelBuilderConfigurationOptions(
                OrganizationSetupServiceDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}