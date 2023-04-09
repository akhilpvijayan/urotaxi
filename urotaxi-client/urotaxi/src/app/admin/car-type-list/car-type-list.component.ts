import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { AuthserviceService } from 'src/app/services/authservice.service';
import { CarTypeService } from 'src/app/services/car-type.service';
import { AddCarTypeComponent } from './add-car-type/add-car-type.component';

@Component({
  selector: 'app-car-type-list',
  templateUrl: './car-type-list.component.html',
  styleUrls: ['./car-type-list.component.scss']
})
export class CarTypeListComponent implements OnInit {
  filter!: string;
  page: number = 1;

  constructor(
    public carTypeService: CarTypeService,
    private router: Router, private authService: AuthserviceService, public dialog: MatDialog
  ) { }



  ngOnInit(): void {

    this.carTypeService.getCarTypes();
    
  }

  updateCarType(Id: number) {
    //this.router.navigate(['add-staff', Id, 0]);
  }

  DeleteCarType(Id:number){
    if (confirm("The Car Type data will be removed ! Are you sure?")) {
      this.carTypeService.deleteCarType(Id).subscribe(
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

    addCarType(){[
      this.dialog.open(AddCarTypeComponent,{width:'790px', height:'200px', hasBackdrop:true, panelClass: 'custom-dialog-container' })
    ]}
  }

