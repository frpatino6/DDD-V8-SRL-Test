import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { EmployeeServices } from 'src/app/services/employee-slaray-service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.scss']
})
export class EmployeeComponent implements OnInit {

  dataSource: any;
  displayedColumns = ['NombreCompleto', 'Division', 'Posicion', 'FechaInicio', 'Cumpleanos', 'NumeroIdentificacion', 'SalarioTotal','actions'];
  constructor(private employeeServices: EmployeeServices) { }

  ngOnInit(): void {
    this.employeeServices.getAllEmployees().subscribe((result) => {
      console.log(result);
      this.dataSource = result;
    },
    (err: HttpErrorResponse) => {
      console.log(err);
    }
    );
  }

}
