import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { EmployeeServices } from 'src/app/services/employee-salary-service';

@Component({
  selector: 'app-employee-last-salarie',
  templateUrl: './employee-last-salarie.component.html',
  styleUrls: ['./employee-last-salarie.component.scss']
})
export class EmployeeLastSalarieComponent implements OnInit {
  dataSource: any;
  displayedColumns = [
    'NombreCompleto',
    'Month',
    'Year',
    'Bono',
    'SalarioTotal'
  ];

  constructor(private employeeServices: EmployeeServices, ) { }

  ngOnInit(): void {
  }

  getLastEmployeeSalary(employeeCode): void{
    this.employeeServices.getLastEmployeesSalary(employeeCode, '5').subscribe(
      (result) => {
        this.dataSource = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
}
