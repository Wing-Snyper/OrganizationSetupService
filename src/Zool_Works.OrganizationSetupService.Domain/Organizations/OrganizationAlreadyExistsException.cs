using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace Zool_Works.OrganizationSetupService.Organizations
{
    class OrganizationAlreadyExistsException : BusinessException
    {
        public OrganizationAlreadyExistsException(string name)
            : base(OrganizationDomainErrorCodes.OrganizationAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
