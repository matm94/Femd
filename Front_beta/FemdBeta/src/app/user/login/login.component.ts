import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/Shared/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor( public userService: UserService, private router: Router) { }

  ngOnInit(): void {
    if (localStorage.getItem('token') != null)
    {
      this.router.navigateByUrl('/home');
    }
  }

  onSubmit(): void  {
    this.userService.loginUser().subscribe(
      (res: any) =>
      {
        localStorage.setItem('token', res.token);
        this.router.navigateByUrl('/home');
      },
      err =>
      {
        // tslint:disable-next-line: triple-equals
        if (err.status == 400) {
          console.log(err);
         }

      }
    );
  }
}
