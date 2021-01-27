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

  personalPronoun = new Array<PersonalPronoun>();
  ngOnInit(): void {
  }

  getPersonalPronoun(): void
  {
    this.lectureService.getPerspnalPronoun()
        .subscribe( data =>
          {
            console.log(data);
            this.personalPronoun = [data].map(item =>
              {
                  return new PersonalPronoun(
                    item.translation,
                    item.firstPerson,
                    item.secondPerson,
                    item.thirdPerson,
                    item.firstPersonPlural,
                    item.secondPersonPlural,
                    item.thirdPersonPlural,
                    item.formal,
                  );
              });
          });
  }


}
