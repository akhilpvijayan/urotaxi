import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Booking } from '../shared/booking';
import { BookingDetail } from '../shared/booking-detail';

@Injectable({
  providedIn: 'root'
})
export class BookingService {
  formData:BookingDetail=new BookingDetail();
  bookingDetails !: BookingDetail[];

  bookingData:Booking=new Booking();
  booking !: Booking[];
  constructor(private httpClient: HttpClient) { }

  //get bookig details
  getBookingDetails(carModelId: number){
    this.httpClient.get(environment.apiUrl + '/booking/detail/' + carModelId)
    .toPromise().then(
      response => this.bookingDetails = response as BookingDetail[]);
      
    }

    //insert a booking
    addBooking(booking: Booking): Observable<any> {
      return this.httpClient.post(environment.apiUrl + "/booking/", booking);
  
    }
  
}
