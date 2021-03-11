import { TestBed } from '@angular/core/testing';

import { OrganizationSetupServiceService } from './organization-setup-service.service';

describe('OrganizationSetupServiceService', () => {
  let service: OrganizationSetupServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OrganizationSetupServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
