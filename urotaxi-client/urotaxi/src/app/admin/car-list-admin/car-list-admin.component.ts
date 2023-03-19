import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CarModelService } from 'src/app/services/car-model.service';

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
    private router: Router
  ) { }



  ngOnInit(): void {

    this.carModelService.getCarModelsbyVM();
    
  }

  updateStaff(Id: number) {
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
  }

