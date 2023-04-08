import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../shared/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  formData:User=new User();
  users !: User[];
  constructor(private httpClient: HttpClient) { }
  //get all users
  getUsers(){
    this.httpClient.get(environment.apiUrl + '/user')
    .toPromise().then(
      response => this.users = response as User[])
  }

  //get particular user
  getUser(userId: number) {
    this.httpClient.get(environment.apiUrl + '/user/' + userId)
    .toPromise().then(
      response => this.users = response as User[]);;
    }

  //get all drivers
  getDrivers(){
    this.httpClient.get(environment.apiUrl + '/user/drivers')
    .toPromise().then(
      response => this.users = response as User[])
  }
    
  deleteUser(id:number){
    return this.httpClient.delete(environment.apiUrl+'/user/' +id);
  }
  
  //insert a user
  addUser(user: User): Observable<any> {
    return this.httpClient.post(environment.apiUrl + "/user/", user);

  }
}
