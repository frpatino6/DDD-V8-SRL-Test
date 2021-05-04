import { Inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { DOCUMENT } from '@angular/common';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { OfficeDTO } from '../models/office';

@Injectable()
export class OfficeServices {
  strUrl = '';
  header = new HttpHeaders();
  constructor(private http: HttpClient, @Inject(DOCUMENT) document: any) {
    this.header
      .set('Content-Type', 'application/json')
      .set('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, DELETE')
      .set('Allow', 'GET, POST, OPTIONS, PUT, DELETE')
      .set('Access-Control-Allow-Origin', '*');
    this.strUrl = `${environment.apiUrl}`;
  }

  public getAllOffice(): Observable<OfficeDTO> {
    const controler = 'Office';
    const strlcl = this.strUrl + controler;
    return this.http.get<OfficeDTO>(strlcl, { headers: this.header });
  }
}
