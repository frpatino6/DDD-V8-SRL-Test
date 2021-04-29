import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeComponent } from './components/employee/employee.component';
import { EmployeeSalaryListComponent } from './components/employee-salary-list/employee-salary-list.component';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot([
    { path: '', component: EmployeeComponent },
    { path: 'salaries_employees', component: EmployeeSalaryListComponent }
  ])],
  exports: [RouterModule]
})
export class AppRoutingModule { }
