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

  noun = new Array<PartsOfSpeech>();
  ngOnInit(): void {
  }

  getNoun(): void
  {
    this.lectureService.getNoun()
        .subscribe( data =>
          {
            console.log(data);
            this.noun = [data].map(item =>
              {
                  return new PartsOfSpeech(
                    item.translation,
                    item.content,
                    item.photoPath,
                  );
              });
          });
  }

}
