import { Lecture } from './../../../Models/Lecture';
import { Observable } from 'rxjs';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { LectureAPIService } from 'src/app/Shared/lecture.service';
@Component({
  selector: 'app-all-lecture-menu',
  templateUrl: './all-lecture-menu.component.html',
  styleUrls: ['./all-lecture-menu.component.css']
})
export class AllLectureMenuComponent implements OnInit {

  allLecture;
  @Output()
  emitLectureNumber: EventEmitter<string> = new EventEmitter();

  constructor(private lectureService: LectureAPIService) { }

  ngOnInit(): void {
    this.GetAllLecture();
  }

  // w tym komponencie bedzie lista wszystkich lekcji, wybierajac jakas bedzie przekazywane
  // outputem i eventemiterme string lub number z numerem lekcji, wg ktorego kolejne komponenty
  // beda pobierac z api odpowiednie dane do lekcji

  GetLecture(lectureNumber: string): void
  {
    console.log(lectureNumber);
    this.emitLectureNumber.emit(lectureNumber);
  }

  GetAllLecture(): Observable<Lecture[]>
  {
    this.lectureService.getAllLecture().subscribe( data =>
      {
        this.allLecture = data;
        console.log(this.allLecture);
      });
    return this.allLecture;
  }

  GetAllLectureMapData(): void
  {
  }

}
