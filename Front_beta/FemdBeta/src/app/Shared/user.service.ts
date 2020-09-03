import { RegisterUser } from './../Interfaces/RegisterUser';
import { LoginUser } from './../Interfaces/LoginUser';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { FormBuilder, Validators} from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private formBuilder: FormBuilder, private http: HttpClient) { }

  registerModel = this.formBuilder.group({
    Login: ['', Validators.required],
    Email: ['', [Validators.required, Validators.email]],
    Password: ['', [Validators.required, Validators.minLength(4)]]
  });

  loginModel = this.formBuilder.group({
    Email: ['', [Validators.required, Validators.email]],
    Password: ['', [Validators.required, Validators.minLength(4)]]
  });

  registerUser(): Observable<RegisterUser>
  {
    const newUser: RegisterUser =
    {
      Login: this.registerModel.value.Login,
      Email: this.registerModel.value.Email,
      Password: this.registerModel.value.Password,
      Role: 'User'
    };
    return this.http.post<RegisterUser>('https://localhost:44366/api/Account/Register', newUser);
  }

  loginUser(): Observable<LoginUser>
  {
    const loginUser: LoginUser =
    {
      Email: this.loginModel.value.Email,
      Password: this.loginModel.value.Password,
    };
    return this.http.post<LoginUser>('https://localhost:44366/api/Account/Login', loginUser);
  }

  // tslint:disable-next-line: typedef
  getUserAccount()
  {
    return this.http.get('https://localhost:44366/api/Account');
  }


}
