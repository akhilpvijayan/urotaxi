import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { CarTypeService } from '../services/car-type.service';
import { CityService } from '../services/city.service';
import { DashboardForm } from '../shared/dashboard-form';
import {MatDialog} from '@angular/material/dialog';
import { LoginComponent } from '../login/login.component';
import { AuthserviceService } from '../services/authservice.service';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  closeResult = '';
  dashBoardForm : DashboardForm = new DashboardForm;
  constructor(public carTypeService : CarTypeService,public authService: AuthserviceService, public httpClient : HttpClient, public cityService : CityService, private router: Router, public dialog: MatDialog) { }
  uName = localStorage.getItem('uName');
  ngOnInit(): void {
      this.carTypeService.getCarTypes();
      this.cityService.getCities();
  }
  onSubmit(form: NgForm){
    var formData = [];
    formData[0] = form.form.value.Source;
    formData[1] = form.form.value.Destination;
    formData[2] = form.form.value.Date;
    localStorage.setItem("dashboardForm", JSON.stringify(formData));
    this.router.navigate(['/cars',form.form.value.CarType]);
  }

  login(){ 
    this.dialog.open(LoginComponent,{width:'790px', height:'460px', hasBackdrop:true, panelClass: 'custom-dialog-container' });
  }

  logOut(){
    this.authService.logOut();
    window.location.reload();
  }

  navigateAdmin(){
    this.router.navigateByUrl('/admin');
  }
}
