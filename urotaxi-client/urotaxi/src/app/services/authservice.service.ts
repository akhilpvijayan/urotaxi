import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../shared/user';

@Injectable({
  providedIn: 'root'
})
export class AuthserviceService {

  constructor(private httpClient: HttpClient) { }

  login(data: any):Observable<any>{
    return this.httpClient.get(environment.apiUrl + "/login/"+data.Username+"/"+data.Password);
  }

  register(data: User): Observable<any>{
    return this.httpClient.post(environment.apiUrl + "/register/", data);
  }
}
