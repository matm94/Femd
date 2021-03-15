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

  adverb: PartsOfSpeech;
  ngOnInit(): void {
  }

  getAdverb(): PartsOfSpeech
  {
    this.lectureService.getAdverb()
        .subscribe( data =>
          {
            this.adverb = data;
            console.log(this.adverb);
          });
    return this.adverb;
  }

}
