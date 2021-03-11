using Xunit;
using Zool_Works.OrganizationSetupService.Samples;

namespace Zool_Works.OrganizationSetupService.MongoDB.Samples
{
    [Collection(MongoTestCollection.Name)]
    public class SampleRepository_Tests : SampleRepository_Tests<OrganizationSetupServiceMongoDbTestModule>
    {
        /* Don't write custom repository tests here, instead write to
         * the base class.
         * One exception can be some specific tests related to MongoDB.
         */
    }
}
