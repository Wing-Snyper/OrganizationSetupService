import { ModuleWithProviders, NgModule } from '@angular/core';
import { ORGANIZATION_SETUP_SERVICE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class OrganizationSetupServiceConfigModule {
  static forRoot(): ModuleWithProviders<OrganizationSetupServiceConfigModule> {
    return {
      ngModule: OrganizationSetupServiceConfigModule,
      providers: [ORGANIZATION_SETUP_SERVICE_ROUTE_PROVIDERS],
    };
  }
}
