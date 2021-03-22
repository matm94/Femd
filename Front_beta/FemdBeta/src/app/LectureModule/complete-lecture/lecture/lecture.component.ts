import { Component, Input, OnInit } from '@angular/core';
import { LectureRouterServiceService } from 'src/app/Shared/lecture-router-service.service';

@Component({
  selector: 'app-lecture',
  templateUrl: './lecture.component.html',
  styleUrls: ['./lecture.component.css']
})
export class LectureComponent implements OnInit {

  @Input()
  lectureNumber: string;

  constructor(private router: LectureRouterServiceService) { }

  ngOnInit(): void {
  }

  goAdjective(): void
  {
    this.router.goToWords();
  }

  goText(): void
  {
    this.router.goToTextArea();
  }
  goPictures(): void
  {
    this.router.goToPictures();
  }
  goDictionary(): void
  {
    this.router.goToAllWordsOfLecture();
  }

}
