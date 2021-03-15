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

  verb: Verb;
  ngOnInit(): void {
  }
  getVerb(): Verb
  {
    this.lectureService.getVerb()
        .subscribe( data =>
          {
            this.verb = data;
            console.log(this.verb);
          });
    return this.verb;
  }

}
