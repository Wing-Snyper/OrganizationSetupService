using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Zool_Works.OrganizationSetupService.EntityFrameworkCore;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public class EfCoreOrganizationRepository
        : EfCoreRepository<OrganizationSetupServiceDbContext, Organization, Guid>, IOrganizationRepository
    {
        public EfCoreOrganizationRepository(
            IDbContextProvider<OrganizationSetupServiceDbContext> dbContextProvider)
            : base(dbContextProvider)            
        {

        }
        public Task<Organization> FindByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Organization>> GetListAsync(int skipCount, int maxResultCount, string sorting, string filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
