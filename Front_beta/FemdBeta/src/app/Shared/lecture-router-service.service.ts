import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class LectureRouterServiceService {

  constructor(private router: Router) { }

  goToWords(): void
  {
    this.router.navigate(['adjective']);
  }

  goToTextArea(): void
  {
    this.router.navigate(['textfield']);
  }
  goToPictures(): void
  {
    this.router.navigate(['picture-module']);
  }
  goToAllWordsOfLecture(): void
  {
    this.router.navigate(['words-dictionary']);
  }
  goToCompleteLecture(): void
  {
    this.router.navigate(['complete-lecture'])
  }

}
