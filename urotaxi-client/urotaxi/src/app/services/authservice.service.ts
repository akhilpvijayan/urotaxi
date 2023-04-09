import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../shared/user';

@Injectable({
  providedIn: 'root'
})
export class AuthserviceService {
  isLoggedIn = false;
  loggedResult:any;
  constructor(private httpClient: HttpClient) {
    const token = localStorage.getItem('uroTaxi auth');
    if(token){
      this.isLoggedIn = true;
    }
   }

   login(Username:string,Password:string):Observable<any>{
    return this.httpClient.get(environment.apiUrl + "/login/"+Username+"/"+Password);
  }

  register(data: User): Observable<any>{
    return this.httpClient.post(environment.apiUrl + "/register/", data);
  }

  authData(data:any){
    this.loggedResult = data;
    localStorage.setItem('uName',this.loggedResult.uName);
    localStorage.setItem('uId',this.loggedResult.uId);
  }

    public logOut(){
      localStorage.clear();
      sessionStorage.clear();
    }
  
}
