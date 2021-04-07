import { Component, Input, OnInit } from '@angular/core';
import { CompleteLecture } from 'src/app/Models/CompleteLecture';
import { LectureRouterServiceService } from 'src/app/Shared/lecture-router-service.service';

@Component({
  selector: 'app-textfield',
  templateUrl: './textfield.component.html',
  styleUrls: ['./textfield.component.css']
})
export class TextfieldComponent implements OnInit {

  //zmienić jesli dane beda wysylane z odrebnej klasy textfield
  @Input()
  completeLectureText: CompleteLecture;

  constructor(private router: LectureRouterServiceService) { }

  ngOnInit(): void {
  }
  goAdjective(): void
  {
    this.router.goToWords();
  }

}
