import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { CarTypeService } from '../services/car-type.service';
import { CityService } from '../services/city.service';
import { DashboardForm } from '../shared/dashboard-form';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  dashBoardForm : DashboardForm = new DashboardForm;
  constructor(public carTypeService : CarTypeService, public httpClient : HttpClient, public cityService : CityService, private router: Router) { }
  ngOnInit(): void {
      this.carTypeService.getCarTypes();
      this.cityService.getCities();
  }
  onSubmit(form: NgForm){
    this.router.navigate(['/cars',form.form.value.CarType]);
  }

}
