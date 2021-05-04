import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { OfficeServices } from '../../services/officeServices';
import { PositionServices } from '../../services/positionServicesy';
import { DivisionServices } from '../../services/divisionServices';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.scss'],
})
export class AddEmployeeComponent implements OnInit {
  dataSourceOffice: any;
  dataSourcePosition: any;
  dataSourceDivision: any;
  startDate = new Date(1990, 0, 1);
  selectedOffice = '';
  selectedPosition = '';
  selectedDivision = '';

  constructor(
    private officeService: OfficeServices,
    private positionServices: PositionServices,
    private divisionService: DivisionServices
  ) {}

  ngOnInit(): void {
    this.getAllOffices();
    this.getAllDivision();
    this.getAllPositions();
  }

  getAllOffices(): void {
    this.officeService.getAllOffice().subscribe(
      (result) => {
        this.dataSourceOffice = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
  getAllPositions(): void {
    this.positionServices.getAllPositions().subscribe(
      (result) => {
        this.dataSourcePosition = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
  getAllDivision(): void {
    this.divisionService.getAllDivision().subscribe(
      (result) => {
        this.dataSourceDivision = result;
      },
      (err: HttpErrorResponse) => {
        console.log(err);
      }
    );
  }
}
