import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class NavBarService {

  constructor(private router: Router) { }
  onLogout(): void
  {
    localStorage.removeItem('token');
    this.router.navigate(['user/login']);
  }
  goToHome(): void
  {
    this.router.navigate(['home']);
  }
  goToNewLesson(): void
  {
    this.router.navigate(['newLesson']);
  }

  goToRepeats(): void
  {
    this.router.navigate(['repeats']);
  }
  goToWords(): void
  {
    this.router.navigate(['words']);
  }
  goToLessons(): void
  {
    this.router.navigate(['lessons']);
  }
  goToQuiz(): void
  {
    this.router.navigate(['quiz']);
  }
  goToTopTen(): void
  {
    this.router.navigate(['topTen']);
  }
  goToProfile(): void
  {
    this.router.navigate(['userProfile']);
  }
  goToSettings(): void
  {
    this.router.navigate(['settings']);
  }
}
