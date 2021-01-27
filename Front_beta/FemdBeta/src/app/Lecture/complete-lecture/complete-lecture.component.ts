import { LectureRouterServiceService } from './../../Shared/lecture-router-service.service';
import { Verb } from '../../Models/Verb';
import { PersonalPronoun } from '../../Models/PersonalPronoun';
import { Lecture } from '../../Models/Lecture';
import { PartsOfSpeech } from '../../Models/PartsOfSpeech';
import { CompleteLecture } from '../../Models/CompleteLecture';
import { LectureService } from './../../Shared/lecture.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-complete-lecture',
  templateUrl: './complete-lecture.component.html',
  styleUrls: ['./complete-lecture.component.css']
})
export class CompleteLectureComponent implements OnInit {

  constructor(public lectureService: LectureService, private router: LectureRouterServiceService) { }

  lecture = new Array<Lecture>();
  ngOnInit(): void{

    this.getLecture();
  }

  getLecture(): void
  {
    this.lectureService.getLecture()
        .subscribe( data =>
          {
            console.log(data);
            this.lecture = [data].map(item =>
              {
                  return new Lecture(

                    item.id,
                    item.name,
                    item.lectureNumber,
                    item.description,
                  );
              });
          });
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
