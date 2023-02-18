import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { City } from '../shared/city';

@Injectable({
  providedIn: 'root'
})
export class CityService {
  formData:City=new City();
  city !: City[];
  constructor(private httpClient: HttpClient) { }
  //get all cities
  getCities(){
    this.httpClient.get(environment.apiUrl + '/city')
    .toPromise().then(
      response => this.city = response as City[])
  }
  //get particular city
  getCity(cityId: number): Observable<any> {
    return this.httpClient.get(environment.apiUrl + '/city/' + cityId);
      
    }
  
}
