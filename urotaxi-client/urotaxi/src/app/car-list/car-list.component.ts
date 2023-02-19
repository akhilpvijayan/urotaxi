import { Component, OnInit } from '@angular/core';
import { CarModelService } from '../services/car-model.service';
import { CarTypeService } from '../services/car-type.service';
import { NgForm } from '@angular/forms';
import { DashboardForm } from '../shared/dashboard-form';

@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.scss']
})
export class CarListComponent implements OnInit {

  constructor(public carModelService : CarModelService, public carTypeService : CarTypeService){}
  p: number = 1;
  dashBoardForm : DashboardForm = new DashboardForm;
  ngOnInit() {
    this.carModelService.getCarModels();
    this.carTypeService.getCarTypes();
  }
  onSubmit(form: NgForm){
    this.carModelService.getCarModels();
  }
}

