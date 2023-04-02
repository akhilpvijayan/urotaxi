import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Fueltype } from '../shared/fueltype';

@Injectable({
  providedIn: 'root'
})
export class FuelTypeService {
  formData:Fueltype=new Fueltype();
  fuelType !: Fueltype[];
  constructor(private httpClient: HttpClient) { }
  //get all fuel types
  getFuelTypes(){
    this.httpClient.get(environment.apiUrl + '/fueltype')
    .toPromise().then(
      response => this.fuelType = response as Fueltype[])
    }
}
