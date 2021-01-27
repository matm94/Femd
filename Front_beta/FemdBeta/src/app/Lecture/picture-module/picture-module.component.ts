import { Component, OnInit } from '@angular/core';
import { LectureRouterServiceService } from 'src/app/Shared/lecture-router-service.service';

@Component({
  selector: 'app-picture-module',
  templateUrl: './picture-module.component.html',
  styleUrls: ['./picture-module.component.css']
})
export class PictureModuleComponent implements OnInit {

  constructor( private router: LectureRouterServiceService) { }

  ngOnInit(): void {
  }

  goDictionary(): void
  {
    this.router.goToAllWordsOfLecture();
  }

}
