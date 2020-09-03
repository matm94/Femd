import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {RegisterUser} from '../Interfaces/RegisterUser';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpClientService {

  constructor( private http: HttpClient) { }

  Registration(registerUser: RegisterUser): Observable<RegisterUser>
  {
    return this.http.post<RegisterUser>('https://localhost:44366/api/Account/Register', registerUser);
  }
}
