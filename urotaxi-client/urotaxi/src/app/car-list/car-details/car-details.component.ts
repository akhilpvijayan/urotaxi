import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { BookingService } from 'src/app/services/booking.service';
import { DashboardForm } from 'src/app/shared/dashboard-form';
import { Location } from '@angular/common';
import { LoginComponent } from 'src/app/login/login.component';
import { MatDialog } from '@angular/material/dialog';
import { AuthserviceService } from 'src/app/services/authservice.service';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.scss']
})
export class CarDetailsComponent implements OnInit {
id:string | null = '';
  constructor(private _Activatedroute: ActivatedRoute,private authService: AuthserviceService, public bookingService: BookingService, private router : Router, private _location: Location, public dialog: MatDialog) {
    this._Activatedroute.paramMap.subscribe(paramMap => { 
    this.id = paramMap.get('id'); 
}); }
dashBoardForm : DashboardForm = new DashboardForm;
formData : any

  ngOnInit(): void {
    this.formData = JSON.parse(localStorage.getItem('dashboardForm') || '{}');
    this.bookingService.getBookingDetails(Number(this.id));
  }

  onSubmit(form: NgForm){
    if(localStorage.getItem('uroTaxi auth')){
      form.value.pickupdate = this.formData[2];
      form.value.source = this.formData[0];
      form.value.destination = this.formData[1];
      form.value.bookedUser = localStorage.getItem('uId');
      form.value.carModel = this.id;
      this.bookingService.addBooking(form.value).subscribe(
        (result) => {
          console.log(result);
          this.resetForm(form);
          localStorage.removeItem('dashboardForm');
        }
      )
      this.router.navigate(['/home']);
    }
    else{
      this.dialog.open(LoginComponent,{width:'790px', height:'460px', hasBackdrop:true, panelClass: 'custom-dialog-container' });
    }
  }
  

  onCancel(){
    this._location.back();
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.reset();
    }
  }
}
