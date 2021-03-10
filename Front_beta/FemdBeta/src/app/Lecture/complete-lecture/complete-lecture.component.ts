import { CompleteLecture } from './../../Models/CompleteLecture';
import { LectureRouterServiceService } from './../../Shared/lecture-router-service.service';
import { Verb } from '../../Models/Verb';
import { PersonalPronoun } from '../../Models/PersonalPronoun';
import { Lecture } from '../../Models/Lecture';
import { PartsOfSpeech } from '../../Models/PartsOfSpeech';
import { LectureService } from './../../Shared/lecture.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-complete-lecture',
  templateUrl: './complete-lecture.component.html',
  styleUrls: ['./complete-lecture.component.css']
})
export class CompleteLectureComponent implements OnInit {

  constructor(public lectureService: LectureService, private router: LectureRouterServiceService) { }

  lectureApi: Lecture;
  ngOnInit(): void{

    this.getLecture();
  }

  getLecture(): Lecture
  {
    this.lectureService.getLecture()
        .subscribe( data =>
          {
            this.lectureApi = data;
            console.log(this.lectureApi);
          });
    return this.lectureApi;
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
