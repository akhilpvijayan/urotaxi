import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { BookingDetail } from '../shared/booking-detail';

@Injectable({
  providedIn: 'root'
})
export class BookingService {
  formData:BookingDetail=new BookingDetail();
  bookingDetails !: BookingDetail[];
  constructor(private httpClient: HttpClient) { }

  //get bookig details
  getBookingDetails(carModelId: number){
    this.httpClient.get(environment.apiUrl + '/booking/detail/' + carModelId)
    .toPromise().then(
      response => this.bookingDetails = response as BookingDetail[]);
      
    }
  
}
