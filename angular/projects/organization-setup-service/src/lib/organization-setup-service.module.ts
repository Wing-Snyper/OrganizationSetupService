import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { OrganizationSetupServiceComponent } from './components/organization-setup-service.component';
import { OrganizationSetupServiceRoutingModule } from './organization-setup-service-routing.module';

@NgModule({
  declarations: [OrganizationSetupServiceComponent],
  imports: [CoreModule, ThemeSharedModule, OrganizationSetupServiceRoutingModule],
  exports: [OrganizationSetupServiceComponent],
})
export class OrganizationSetupServiceModule {
  static forChild(): ModuleWithProviders<OrganizationSetupServiceModule> {
    return {
      ngModule: OrganizationSetupServiceModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<OrganizationSetupServiceModule> {
    return new LazyModuleFactory(OrganizationSetupServiceModule.forChild());
  }
}
