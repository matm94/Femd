import { Observable } from 'rxjs';
import { UserService } from './../../Shared/user.service';
import { RegisterUser } from './../../Interfaces/RegisterUser';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-component',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']

})
export class RegistrationComponent implements OnInit {

  constructor( public userService: UserService) { }

  ngOnInit(): void {

  }

  onSubmit()
  {
    this.userService.registerUser().subscribe();
    console.log('poszlo- rejestracja');
  }


}
