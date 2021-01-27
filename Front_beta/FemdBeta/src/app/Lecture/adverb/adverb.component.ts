import { Component, OnInit } from '@angular/core';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';
import { LectureService } from 'src/app/Shared/lecture.service';

@Component({
  selector: 'app-adverb',
  templateUrl: './adverb.component.html',
  styleUrls: ['./adverb.component.css']
})
export class AdverbComponent implements OnInit {

  constructor(public lectureService: LectureService) { }

  adverb = new Array<PartsOfSpeech>();
  ngOnInit(): void {
  }

  getAdverb(): void
  {
    this.lectureService.getAdverb()
        .subscribe( data =>
          {
            console.log(data);
            this.adverb = [data].map(item =>
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
