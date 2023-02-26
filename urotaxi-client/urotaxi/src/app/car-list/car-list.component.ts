import { Component, OnInit } from '@angular/core';
import { CarModelService } from '../services/car-model.service';
import { CarTypeService } from '../services/car-type.service';
import { NgForm } from '@angular/forms';
import { DashboardForm } from '../shared/dashboard-form';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.scss']
})
export class CarListComponent implements OnInit {
id:string|null= '';
  constructor(public carModelService : CarModelService, public carTypeService : CarTypeService, private _Activatedroute:ActivatedRoute){
    this._Activatedroute.paramMap.subscribe(paramMap => { 
      this.id = paramMap.get('id'); 
  });
  }
  p: number = 1;
  carTypeId = this.id;
  carType = '';
  dashBoardForm : DashboardForm = new DashboardForm;
  ngOnInit() {
    this.carModelService.getCarModelByCarType(Number(this.id));
    this.carModelService.getCarModel(Number(this.id));
    this.carTypeService.getCarTypes();
    console.log(Number(this.id));
  }
  onSubmit(form: NgForm){
    this.carModelService.getCarModelByCarType(form.value.CarType);
  }
}

