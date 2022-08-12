import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './components/footer/footer.component';
import { HeaderComponent } from './components/header/header.component';
import { EnterpriseComponent } from './components/enterprise/enterprise.component';
import { CreateComponent } from './components/enterprise/create/create.component';
import { EditComponent } from './components/enterprise/edit/edit.component';
import { DepartmentComponent } from './components/department/department.component';
import { CreateComponent as CreateDepartment } from './components/department/create/create.component';
import { EditComponent as EditDepartment } from './components/department/edit/edit.component';

import { ReactiveFormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http'
import { DataTablesModule } from 'angular-datatables';
import { EmployeeComponent } from './components/employee/employee.component';

@NgModule({
  declarations: [
    AppComponent,
    EnterpriseComponent,
    FooterComponent,
    HeaderComponent,
    CreateComponent,
    EditComponent,
    DepartmentComponent,
    CreateDepartment,
    EditDepartment,
    EmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    DataTablesModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
