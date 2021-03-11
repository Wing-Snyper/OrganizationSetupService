import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class OrganizationSetupServiceService {
  apiName = 'OrganizationSetupService';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/OrganizationSetupService/sample' },
      { apiName: this.apiName }
    );
  }
}
