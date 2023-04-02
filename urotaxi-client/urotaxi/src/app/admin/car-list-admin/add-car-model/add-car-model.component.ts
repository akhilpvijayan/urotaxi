import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { NgForm } from '@angular/forms';
import { CarModelService } from 'src/app/services/car-model.service';
import { CarModel } from 'src/app/shared/car-model';
import { CarTypeService } from 'src/app/services/car-type.service';
import { FuelTypeService } from 'src/app/services/fuel-type.service';

@Component({
  selector: 'app-add-car-model',
  templateUrl: './add-car-model.component.html',
  styleUrls: ['./add-car-model.component.scss']
})
export class AddCarModelComponent implements OnInit {
  carModelForm: CarModel = new CarModel;
  constructor(private dialogRef: MatDialogRef<AddCarModelComponent>, private carModelService: CarModelService, public carTypeService: CarTypeService,
    public fuelTypeService: FuelTypeService) { }

  ngOnInit(): void {
    this.carTypeService.getCarTypes();
    this.fuelTypeService.getFuelTypes();
  }

  onSubmit(form: NgForm) {
    form.value.isActive = true;
    form.value.carModelId = 0;
    if(form.value.isAc == 1){
      form.value.isAc = true;
    }
    else{
      form.value.isAc = false;
    }
    this.carModelService.addCarModel(form.value).subscribe(
      (result) => {
        this.resetForm(form);
        this.closeLog();
        window.location.reload();
      }
    )
  }

  closeLog() {
    this.dialogRef.close();
  }

  
  resetForm(form?: NgForm) {
    if (form != null) {
      form.reset();
    }
  }
}
