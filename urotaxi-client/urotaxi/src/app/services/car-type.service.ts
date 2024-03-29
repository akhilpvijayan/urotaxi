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
  carTypes !: CarType[];
  carType !: CarType[];
  constructor(private httpClient: HttpClient) { }
  //get all car types
  getCarTypes(){
    this.httpClient.get(environment.apiUrl + '/cartype')
    .toPromise().then(
      response => this.carTypes = response as CarType[])
  }
  //get particular car type
  getCarType(cartypeId: number) : Observable<any>{
    return this.httpClient.get(environment.apiUrl + '/cartype/' + cartypeId);
    }

  //insert a car type
  addCarType(carType: CarType): Observable<any> {
    return this.httpClient.post(environment.apiUrl + "/cartype/", carType);
  }

  deleteCarType(id:number){
    return this.httpClient.delete(environment.apiUrl+'/cartype/' +id);
  }
}
