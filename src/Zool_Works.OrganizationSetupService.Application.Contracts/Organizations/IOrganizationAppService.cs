using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public interface IOrganizationAppService : IApplicationService
    {
        Task<OrganizationDto> GetAsync(Guid id);

        Task<PagedResultDto<OrganizationDto>> GetListAsync(GetOrganizationListDto input);

        Task<OrganizationDto> CreateAsync(CreateOrganizationDto input);

        Task UpdateAsync(Guid id, UpdateOrganizationDto input);

        Task DeleteAsync(Guid id);
    }
}
