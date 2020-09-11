import { NavBarService } from './../Shared/nav-bar.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  constructor(private router: Router, private navService: NavBarService) { }

  ngOnInit(): void {
  }
  onLogout(): void
  {
    this.navService.onLogout();
  }
  goHome(): void
  {
    this.navService.goToHome();
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
