import { Component, OnInit } from '@angular/core';
import { LectureRouterServiceService } from 'src/app/Shared/lecture-router-service.service';

@Component({
  selector: 'app-textfield',
  templateUrl: './textfield.component.html',
  styleUrls: ['./textfield.component.css']
})
export class TextfieldComponent implements OnInit {

  constructor(private router: LectureRouterServiceService) { }

  ngOnInit(): void {
  }
  goAdjective(): void
  {
    this.router.goToWords();
  }

}
