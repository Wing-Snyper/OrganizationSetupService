import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrganizationSetupServiceComponent } from './components/organization-setup-service.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: OrganizationSetupServiceComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OrganizationSetupServiceRoutingModule {}
