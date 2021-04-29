import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { EmployeeServices } from '../services/employee-slaray-service';

@Component({
  selector: 'app-employee-salary-list',
  templateUrl: './employee-salary-list.component.html',
  styleUrls: ['./employee-salary-list.component.scss']
})
export class EmployeeSalaryListComponent implements OnInit {

  constructor(private employeeServices: EmployeeServices) { }

  ngOnInit(): void {
    this.employeeServices.getAllEmployees().subscribe((result) => {
      console.log(result);
    },
    (err: HttpErrorResponse) => {
      console.log(err);
    }
    );
  }

}
