import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { AuthserviceService } from 'src/app/services/authservice.service';
import { CityService } from 'src/app/services/city.service';
import { AddCityComponent } from './add-city/add-city.component';

@Component({
  selector: 'app-city-list',
  templateUrl: './city-list.component.html',
  styleUrls: ['./city-list.component.scss']
})
export class CityListComponent implements OnInit {
  filter!: string;
  page: number = 1;

  constructor(
    public cityService: CityService,
    private router: Router, private authService: AuthserviceService, public dialog: MatDialog
  ) { }



  ngOnInit(): void {

    this.cityService.getCities();
    
  }

  updateCity(Id: number) {
    //this.router.navigate(['add-staff', Id, 0]);
  }

  DeleteCity(Id:number){
    if (confirm("The city data will be removed ! Are you sure?")) {
      this.cityService.deleteCity(Id).subscribe(
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

    addCity(){[
      this.dialog.open(AddCityComponent,{width:'790px', height:'260px', hasBackdrop:true, panelClass: 'custom-dialog-container' })
    ]}
  
}
