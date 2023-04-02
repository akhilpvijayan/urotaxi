import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { CarModel } from '../shared/car-model';

@Injectable({
  providedIn: 'root'
})
export class CarModelService {
  formData:CarModel=new CarModel();
  carModels !: CarModel[];
  carModel !: CarModel[];
  constructor(private httpClient: HttpClient) { }
  //get all car models
  getCarModels(){
    this.httpClient.get(environment.apiUrl + '/carmodel')
    .toPromise().then(
      response => this.carModels = response as CarModel[])
  }
  //get all car models by VM
  getCarModelsbyVM(){
    this.httpClient.get(environment.apiUrl + '/carmodels')
    .toPromise().then(
      response => this.carModel = response as CarModel[])
  }
  //get particular car model
  getCarModel(carModelId: number) {
    this.httpClient.get(environment.apiUrl + '/carmodel/' + carModelId)
    .toPromise().then(
      response => this.carModels = response as CarModel[]);;
      
    }

  //get car model by car type
  getCarModelByCarType(carTypeId: number){
    this.httpClient.get(environment.apiUrl + '/carmodel/' + carTypeId)
    .toPromise().then(
      response => this.carModels = response as CarModel[]);
      
    }
    
  deleteCarModel(id:number){
    return this.httpClient.delete(environment.apiUrl+'/carModel/' +id);
  }
  
  //insert a car model
  addCarModel(carModel: CarModel): Observable<any> {
    return this.httpClient.post(environment.apiUrl + "/carModel/", carModel);

  }
}
