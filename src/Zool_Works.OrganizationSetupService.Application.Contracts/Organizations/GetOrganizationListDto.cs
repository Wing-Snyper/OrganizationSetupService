using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    public class GetOrganizationListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
