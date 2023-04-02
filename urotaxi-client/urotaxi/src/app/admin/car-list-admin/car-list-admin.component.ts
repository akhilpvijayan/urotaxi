import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { AuthserviceService } from 'src/app/services/authservice.service';
import { CarModelService } from 'src/app/services/car-model.service';
import { AddCarModelComponent } from './add-car-model/add-car-model.component';

@Component({
  selector: 'app-car-list-admin',
  templateUrl: './car-list-admin.component.html',
  styleUrls: ['./car-list-admin.component.scss']
})
export class CarListAdminComponent implements OnInit {
  filter!: string;
  page: number = 1;

  constructor(
    public carModelService: CarModelService,
    private router: Router, private authService: AuthserviceService, public dialog: MatDialog
  ) { }



  ngOnInit(): void {

    this.carModelService.getCarModelsbyVM();
    
  }

  updateCarModel(Id: number) {
    //this.router.navigate(['add-staff', Id, 0]);
  }

  DeleteCarModel(Id:number){
    if (confirm("The car Model data will be removed ! Are you sure?")) {
      this.carModelService.deleteCarModel(Id).subscribe(
        (result) => {
          console.log(result);
          window.location.reload();
        })
        window.location.reload();
        }
        }

    logOut(){
      this.authService.logOut();
      this.router.navigateByUrl('/home');
    }

    addCarModel(){[
      this.dialog.open(AddCarModelComponent,{width:'790px', height:'460px', hasBackdrop:true, panelClass: 'custom-dialog-container' })
    ]}
  }

