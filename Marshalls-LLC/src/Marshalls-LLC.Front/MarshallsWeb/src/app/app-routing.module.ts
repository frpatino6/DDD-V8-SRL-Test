import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EmployeeComponent } from './components/employee/employee.component';
import { EmployeeSalaryListComponent } from './components/employee-salary-list/employee-salary-list.component';
import { EmployeeLastSalarieComponent } from './components/employee-last-salarie/employee-last-salarie.component';
import { AddEmployeeComponent } from './components/add-employee/add-employee.component';
import { EmployeeSalaryListByPositionComponent } from './components/employee-salary-list-by-position/employee-salary-list-by-position.component';

const routes: Routes = [];

@NgModule({
  imports: [
    RouterModule.forRoot([
      { path: '', component: EmployeeComponent },
      {
        path: 'salaries_employees/:employeeCode/:grade',
        component: EmployeeSalaryListComponent,
      },
      {
        path: 'salaries_employees_by_position/:employeeCode/:grade',
        component: EmployeeSalaryListByPositionComponent,
      },
      { path: 'employee_last_salary', component: EmployeeLastSalarieComponent },
      { path: 'employee_add_new', component: AddEmployeeComponent },
    ]),
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
