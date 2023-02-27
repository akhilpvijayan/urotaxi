import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { BookingService } from 'src/app/services/booking.service';
import { DashboardForm } from 'src/app/shared/dashboard-form';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.scss']
})
export class CarDetailsComponent implements OnInit {
id:string | null = '';
  constructor(private _Activatedroute: ActivatedRoute, public bookingService: BookingService) {
    this._Activatedroute.paramMap.subscribe(paramMap => { 
    this.id = paramMap.get('id'); 
}); }
dashBoardForm : DashboardForm = new DashboardForm;
carModelId : Number = Number(this.id);

  ngOnInit(): void {
    this.bookingService.getBookingDetails(Number(this.id));
  }

  onSubmit(form: NgForm){

  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.reset();
    }
  }
}
