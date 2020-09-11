import { NavBarService } from './../Shared/nav-bar.service';
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

  constructor(private router: Router, private userService: UserService, private navService: NavBarService) { }

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
  goNewLesson(): void
  {
    this.navService.goToNewLesson();
  }

  goRepeats(): void
  {
    this.navService.goToRepeats();
  }
  goWords(): void
  {
    this.navService.goToWords();
  }
  goLessons(): void
  {
    this.navService.goToLessons();
  }
  goQuiz(): void
  {
    this.navService.goToQuiz();
  }
  goTopTen(): void
  {
    this.navService.goToTopTen();
  }
  goProfile(): void
  {
    this.navService.goToProfile();
  }
  goSettings(): void
  {
    this.navService.goToSettings();
  }


}
