import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { AuthserviceService } from 'src/app/services/authservice.service';
import { UserService } from 'src/app/services/user.service';
import { AddDriverComponent } from './add-driver/add-driver.component';

@Component({
  selector: 'app-driver-list',
  templateUrl: './driver-list.component.html',
  styleUrls: ['./driver-list.component.scss']
})
export class DriverListComponent implements OnInit {
  filter!: string;
  page: number = 1;
  constructor(
    public userService: UserService,
    private router: Router, private authService: AuthserviceService, public dialog: MatDialog
  ) { }



  ngOnInit(): void {

    this.userService.getDrivers();
    
  }

  DeleteDriver(Id:number){
    if (confirm("The driver data will be removed ! Are you sure?")) {
      this.userService.deleteUser(Id).subscribe(
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

    addUser(){[
      this.dialog.open(AddDriverComponent,{width:'790px', height:'305px', hasBackdrop:true, panelClass: 'custom-dialog-container' })
    ]}
}

