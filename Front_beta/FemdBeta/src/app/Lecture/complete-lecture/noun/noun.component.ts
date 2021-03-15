import { Component, OnInit } from '@angular/core';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';
import { LectureService } from 'src/app/Shared/lecture.service';

@Component({
  selector: 'app-noun',
  templateUrl: './noun.component.html',
  styleUrls: ['./noun.component.css']
})
export class NounComponent implements OnInit {

  constructor(public lectureService: LectureService) { }

  noun: PartsOfSpeech;
  ngOnInit(): void {
  }

  getNoun(): PartsOfSpeech
  {
    this.lectureService.getNoun()
        .subscribe( data =>
          {
            this.noun = data;
            console.log(this.noun);
          });
    return this.noun;
  }

}
