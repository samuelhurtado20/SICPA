import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateComponent } from './components/enterprise/create/create.component';
import { EnterpriseComponent } from './components/enterprise/enterprise.component';
import { EditComponent } from './components/enterprise/edit/edit.component';

import { DepartmentComponent } from './components/department/department.component';
import { CreateComponent as CreateDepartment } from './components/department/create/create.component';
import { EditComponent as EditDepartment } from './components/department/edit/edit.component';

import { EmployeeComponent } from './components/employee/employee.component';
import { CreateComponent as CreateEmployeet } from './components/employee/create/create.component';
import { EditComponent as EditEmployee } from './components/employee/edit/edit.component';

const routes: Routes = [
  { path: 'enterprise', component: EnterpriseComponent },
  { path: 'enterprise/create', component: CreateComponent },
  { path: 'enterprise/edit/:id', component: EditComponent },

  { path: 'department', component: DepartmentComponent },
  { path: 'department/create', component: CreateDepartment },
  { path: 'department/edit/:id', component: EditDepartment },

  { path: 'employee', component: EmployeeComponent },
  { path: 'employee/create', component: CreateEmployeet },
  { path: 'employee/edit/:id', component: EditEmployee }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
