using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    [RemoteService(Name = OrganizationServiceRemoteServiceConsts.RemoteServiceName)]
    [Area("organizationService")]
    [Route("api/organization-service/organizations")]
    public class OrganizationController : OrganizationSetupServiceController, IOrganizationAppService
    {
        private readonly IOrganizationAppService _orgAppSvc;

        public OrganizationController(IOrganizationAppService orgAppSvc)
        {
            _orgAppSvc = orgAppSvc;
        }

        [HttpPost]
        public Task<OrganizationDto> CreateAsync(CreateOrganizationDto input)
        {
            return _orgAppSvc.CreateAsync(input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _orgAppSvc.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<OrganizationDto> GetAsync(Guid id)
        {
            return _orgAppSvc.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<OrganizationDto>> GetListAsync(GetOrganizationListDto input)
        {
            return _orgAppSvc.GetListAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task UpdateAsync(Guid id, UpdateOrganizationDto input)
        {
            return _orgAppSvc.UpdateAsync(id, input);
        }
    }
}
