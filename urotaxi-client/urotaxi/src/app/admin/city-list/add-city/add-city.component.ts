import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { CityService } from 'src/app/services/city.service';
import { City } from 'src/app/shared/city';
import { AddCarModelComponent } from '../../car-list-admin/add-car-model/add-car-model.component';

@Component({
  selector: 'app-add-city',
  templateUrl: './add-city.component.html',
  styleUrls: ['./add-city.component.scss']
})
export class AddCityComponent implements OnInit {

  cityForm: City = new City;
  constructor(private dialogRef: MatDialogRef<AddCarModelComponent>, private cityService: CityService) { }

  ngOnInit(): void {

  }

  onSubmit(form: NgForm) {
    form.value.isActive = true;
    form.value.cityid = 0;
    this.cityService.addCity(form.value).subscribe(
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
