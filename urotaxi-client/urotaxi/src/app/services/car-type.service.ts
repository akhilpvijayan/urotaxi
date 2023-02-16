import { Injectable } from '@angular/core';
import { CarType } from '../shared/car-type';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CarTypeService {
  formData:CarType=new CarType();
  stations !: CarType[];
  constructor(private httpClient: HttpClient) { }
  //get stations
  getStations(){
    this.httpClient.get(environment.apiUrl + '/cartype')
    .toPromise().then(
      response => this.stations = response as CarType[])
  }
  //get particular station
  getStationById(cartypeId: number): Observable<any> {
    return this.httpClient.get(environment.apiUrl + '/cartype/' + cartypeId);
      
    }
  
}
