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

  sentence: PartsOfSpeech;
  ngOnInit(): void {
  }

  getSentence(): PartsOfSpeech
  {
    this.lectureService.getSentence()
        .subscribe( data =>
          {
            this.sentence = data;
            console.log(this.sentence);
          });
    return this.sentence;
  }

}
