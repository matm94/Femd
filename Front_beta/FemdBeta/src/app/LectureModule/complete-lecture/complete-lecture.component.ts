import { PartsOfSpeech } from './../../Models/PartsOfSpeech';
import { CompleteLectureDTO } from './../../Models/CompleteLectureDTO';
import { CompleteLecture } from './../../Models/CompleteLecture';
import { LectureRouterServiceService } from '../../Shared/lecture-router-service.service';
import { Verb } from '../../Models/Verb';
import { PersonalPronoun } from '../../Models/PersonalPronoun';
import { Lecture } from '../../Models/Lecture';
import { LectureAPIService } from '../../Shared/lecture.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-complete-lecture',
  templateUrl: './complete-lecture.component.html',
  styleUrls: ['./complete-lecture.component.css']
})
export class CompleteLectureComponent implements OnInit {

  lectureNumberFromuser: string;
  completeLectureApiData: CompleteLecture;

  constructor(private lectureService: LectureAPIService, private router: LectureRouterServiceService) { }
  ngOnInit(): void{
    this.getCompleteLectureFromUser(this.lectureNumberFromuser);
  }

  getCompleteLectureFromUser(lectureNumberFromuser: string): CompleteLecture
  {
    this.lectureService.getCompleteLecture(lectureNumberFromuser)
        .subscribe( data =>
          {
            this.completeLectureApiData = data;
            console.log('Dane z CompleteLecture: ' + this.completeLectureApiData);
            console.log('Dane z Data z sub: ' + data);
          });
    return this.completeLectureApiData;
  }



}
