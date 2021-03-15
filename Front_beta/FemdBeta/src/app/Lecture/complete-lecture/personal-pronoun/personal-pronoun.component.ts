import { Component, OnInit } from '@angular/core';
import { PersonalPronoun } from 'src/app/Models/PersonalPronoun';
import { LectureService } from 'src/app/Shared/lecture.service';

@Component({
  selector: 'app-personal-pronoun',
  templateUrl: './personal-pronoun.component.html',
  styleUrls: ['./personal-pronoun.component.css']
})
export class PersonalPronounComponent implements OnInit {

  constructor(public lectureService: LectureService) { }

  personalPronoun: PersonalPronoun;
  ngOnInit(): void {
  }

  getPersonalPronoun(): PersonalPronoun
  {
    this.lectureService.getPerspnalPronoun()
        .subscribe( data =>
          {
            this.personalPronoun = data;
            console.log(this.personalPronoun);
          });
    return this.personalPronoun;
  }


}
