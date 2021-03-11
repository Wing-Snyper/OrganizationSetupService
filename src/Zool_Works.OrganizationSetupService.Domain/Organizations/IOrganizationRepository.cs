using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public interface IOrganizationRepository : IRepository<Organization, Guid>
    {
        Task<Organization> FindByNameAsync(string name);
        Task<List<Organization>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
            );
    }
}
