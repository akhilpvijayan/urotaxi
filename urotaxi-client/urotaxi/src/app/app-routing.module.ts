import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminDashboardComponent } from './admin/admin-dashboard/admin-dashboard.component';
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
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
