import { UserService } from 'src/app/Shared/user.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  userData;

  constructor(private router: Router, private userService: UserService) { }

  ngOnInit(): void {
    this.userService.getUserAccount().subscribe(
      res =>
      {
        this.userData = res;
      },
      err =>
      {
        console.log(err);
      }

    );
  }
  onLogout(): void
  {
    localStorage.removeItem('token');
    this.router.navigate(['user/login']);
  }
}
