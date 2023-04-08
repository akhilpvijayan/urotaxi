import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { CarListComponent } from './car-list/car-list.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table'  
import { MatPaginatorModule } from '@angular/material/paginator';
 
import { NgxPaginationModule } from 'ngx-pagination';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { CarDetailsComponent } from './car-list/car-details/car-details.component';
import { LoginComponent } from './login/login.component';
import { SignUpComponent } from './login/sign-up/sign-up.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MatDialogModule } from '@angular/material/dialog';
import { AdminDashboardComponent } from './admin/admin-dashboard/admin-dashboard.component';
import { CarListAdminComponent } from './admin/car-list-admin/car-list-admin.component';
import { AddCarModelComponent } from './admin/car-list-admin/add-car-model/add-car-model.component';
import { CityListComponent } from './admin/city-list/city-list.component';
import { AddCityComponent } from './admin/city-list/add-city/add-city.component';
import { UserListComponent } from './admin/user-list/user-list.component';
import { AddUserComponent } from './admin/user-list/add-user/add-user.component';
import { DriverListComponent } from './admin/driver-list/driver-list.component';
import { AddDriverComponent } from './admin/driver-list/add-driver/add-driver.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    CarListComponent,
    CarDetailsComponent,
    LoginComponent,
    SignUpComponent,
    AdminDashboardComponent,
    CarListAdminComponent,
    AddCarModelComponent,
    CityListComponent,
    AddCityComponent,
    UserListComponent,
    AddUserComponent,
    DriverListComponent,
    AddDriverComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatPaginatorModule,
    NgxPaginationModule,
    Ng2SearchPipeModule,
    NgbModule,
    MatDialogModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
