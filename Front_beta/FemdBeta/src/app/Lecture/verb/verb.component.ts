import { Component, OnInit } from '@angular/core';
import { Verb } from 'src/app/Models/Verb';
import { LectureService } from 'src/app/Shared/lecture.service';

@Component({
  selector: 'app-verb',
  templateUrl: './verb.component.html',
  styleUrls: ['./verb.component.css']
})
export class VerbComponent implements OnInit {

  constructor(public lectureService: LectureService) { }

  verb = new Array<Verb>();
  ngOnInit(): void {
  }
  getVerb(): void
  {
    this.lectureService.getVerb()
        .subscribe( data =>
          {
            console.log(data);
            this.verb = [data].map(item =>
              {
                  return new Verb(
                    item.translation,
                    item.infinitive,
                    item.conjugationTense,
                    item.conjugationIch,
                    item.conjugationDu,
                    item.conjugationEr,
                    item.conjugationWir,
                    item.conjugationIhr,
                    item.conjugationsie,
                    item.conjugationSie,
                  );
              });
          });
  }

}
