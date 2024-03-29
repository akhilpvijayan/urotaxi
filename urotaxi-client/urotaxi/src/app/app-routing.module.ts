import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin/admin-dashboard/admin-dashboard.component';
import { CarListAdminComponent } from './admin/car-list-admin/car-list-admin.component';
import { CarTypeListComponent } from './admin/car-type-list/car-type-list.component';
import { CityListComponent } from './admin/city-list/city-list.component';
import { DriverListComponent } from './admin/driver-list/driver-list.component';
import { UserListComponent } from './admin/user-list/user-list.component';
import { CarDetailsComponent } from './car-list/car-details/car-details.component';
import { CarListComponent } from './car-list/car-list.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { LoginComponent } from './login/login.component';
import { SignUpComponent } from './login/sign-up/sign-up.component';

const routes: Routes = [
  { path: 'home', component: DashboardComponent},
  { path: '', component: DashboardComponent},
  { path: 'cars/:id', component: CarListComponent},
  { path: 'cars/:id/book/:id', component: CarDetailsComponent},
  { path: 'admin', component: AdminDashboardComponent},
  { path: 'car-list-admin', component: CarListAdminComponent},
  { path: 'city-list-admin', component: CityListComponent},
  { path: 'user-list-admin', component: UserListComponent},
  { path: 'driver-list-admin', component: DriverListComponent},
  { path: 'car-type-list-admin', component: CarTypeListComponent},
  { path: 'booking-list-admin', component: DriverListComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
