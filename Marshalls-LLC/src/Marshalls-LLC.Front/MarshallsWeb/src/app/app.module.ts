import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeComponent } from './components/employee/employee.component';
import { ToolBarComponent } from './components/tool-bar/tool-bar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { MatInputModule } from '@angular/material/input';
import { MatTableModule } from '@angular/material/table';
import { EmployeeSalaryListComponent } from './components/employee-salary-list/employee-salary-list.component';
import { EmployeeServices } from './services/employee-salary-service';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeLastSalarieComponent } from './components/employee-last-salarie/employee-last-salarie.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    ToolBarComponent,
    EmployeeSalaryListComponent,
    EmployeeLastSalarieComponent,
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    MatButtonModule,
    MatTableModule,
    MatMenuModule,
    MatToolbarModule,
    MatCardModule,
    MatInputModule,
    BrowserAnimationsModule,
  ],
  exports: [
    MatButtonModule,
    MatMenuModule,
    MatToolbarModule,
    MatCardModule,
    MatInputModule,
  ],
  providers: [EmployeeServices],
  bootstrap: [AppComponent],
})
export class AppModule {}
