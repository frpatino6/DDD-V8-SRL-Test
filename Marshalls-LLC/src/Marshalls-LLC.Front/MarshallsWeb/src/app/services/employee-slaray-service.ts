import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { DOCUMENT } from '@angular/common';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { EmployeeDTO } from '../models/employee';

@Injectable()
export class EmployeeServices {
  strUrl = '';
  constructor(private http: HttpClient, @Inject(DOCUMENT) document: any) {
    this.strUrl = `${environment.apiUrl}`;
  }

  public getAllEmployees(): Observable<EmployeeDTO> {
    let headers = new HttpHeaders();
    headers = headers
    .set('Content-Type', 'application/json')
    .set('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, DELETE')
    .set('Allow', 'GET, POST, OPTIONS, PUT, DELETE')
    .set('Access-Control-Allow-Origin', '*');

    const controler = 'Employee';
    const strlcl = this.strUrl + controler ;
    return this.http.get<EmployeeDTO>(strlcl, {
      headers
    });
  }
}
