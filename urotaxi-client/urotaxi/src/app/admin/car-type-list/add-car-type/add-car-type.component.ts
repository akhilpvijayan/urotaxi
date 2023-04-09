import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { CarTypeService } from 'src/app/services/car-type.service';
import { CarType } from 'src/app/shared/car-type';

@Component({
  selector: 'app-add-car-type',
  templateUrl: './add-car-type.component.html',
  styleUrls: ['./add-car-type.component.scss']
})
export class AddCarTypeComponent implements OnInit {
  carTypeForm: CarType = new CarType;
  constructor(private dialogRef: MatDialogRef<AddCarTypeComponent>, private carTypeService: CarTypeService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    form.value.isActive = true;
    form.value.carTypeId = 0;
    this.carTypeService.addCarType(form.value).subscribe(
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
