import { Component, OnInit } from '@angular/core';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';
import { LectureService } from 'src/app/Shared/lecture.service';

@Component({
  selector: 'app-sentence',
  templateUrl: './sentence.component.html',
  styleUrls: ['./sentence.component.css']
})
export class SentenceComponent implements OnInit {

  constructor(public lectureService: LectureService) { }

  sentence = new Array<PartsOfSpeech>();
  ngOnInit(): void {
  }

  getSentence(): void
  {
    this.lectureService.getSentence()
        .subscribe( data =>
          {
            console.log(data);
            this.sentence = [data].map(item =>
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
