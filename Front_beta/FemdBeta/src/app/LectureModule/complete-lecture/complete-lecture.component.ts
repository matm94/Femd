import { CompleteLecture } from '../../Models/CompleteLecture';
import { LectureRouterServiceService } from '../../Shared/lecture-router-service.service';
import { Verb } from '../../Models/Verb';
import { PersonalPronoun } from '../../Models/PersonalPronoun';
import { Lecture } from '../../Models/Lecture';
import { PartsOfSpeech } from '../../Models/PartsOfSpeech';
import { LectureAPIService } from '../../Shared/lecture.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-complete-lecture',
  templateUrl: './complete-lecture.component.html',
  styleUrls: ['./complete-lecture.component.css']
})
export class CompleteLectureComponent implements OnInit {

  lectureNumber: string;

  constructor(public lectureService: LectureAPIService, private router: LectureRouterServiceService) { }

  completeLectureApi;
  ngOnInit(): void{

    this.getCompleteLecture();
  }

  getLectureNumberFromUser(lectureNumberFromuser: string): void
  {
    this.lectureNumber = lectureNumberFromuser;
  }


  getCompleteLecture(): CompleteLecture
  {
    this.lectureService.getCompleteLecture()
        .subscribe( data =>
          {
            this.completeLectureApi = data;
            console.log(this.completeLectureApi);
          });
    return this.completeLectureApi;
  }

}
