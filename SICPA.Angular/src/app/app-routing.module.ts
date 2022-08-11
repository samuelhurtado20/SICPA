import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateComponent } from './components/enterprise/create/create.component';
import { EnterpriseComponent } from './components/enterprise/enterprise.component';

const routes: Routes = [
  { path: 'enterprise', component: EnterpriseComponent },
  { path: 'enterprise/create', component: CreateComponent },
  //{ path: 'enterprise/list', component: ListEnterpriseComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
