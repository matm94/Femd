import { Component, Input, OnInit } from '@angular/core';
import { CompleteLecture } from 'src/app/Models/CompleteLecture';
import { LectureRouterServiceService } from 'src/app/Shared/lecture-router-service.service';

@Component({
  selector: 'app-words-dictionary',
  templateUrl: './words-dictionary.component.html',
  styleUrls: ['./words-dictionary.component.css']
})
export class WordsDictionaryComponent implements OnInit {

  //zmienić jesli dane z API będą wysyłane z odrębnej klasy
  @Input()
  completeLectureWordsDictionary: CompleteLecture;

  constructor( private router: LectureRouterServiceService) { }

  worter: Array<string> = [
    'Sekretärin gesucht ab sofrt',
    'Zu vekaufen',
    'Zu vermieten',
    'Zimmer zu vermieten',
    'braun',
    'die Wolke',
    'der Baum, Bäume',
    'die Sonne',
    'der Vogel, die Vögel',
    'die Wiese'

  ];

  ngOnInit(): void {
  }

  goNewLesson(): void
  {
    this.router.goToCompleteLecture();
  }


}
