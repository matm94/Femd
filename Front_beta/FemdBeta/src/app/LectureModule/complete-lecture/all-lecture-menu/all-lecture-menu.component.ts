import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-all-lecture-menu',
  templateUrl: './all-lecture-menu.component.html',
  styleUrls: ['./all-lecture-menu.component.css']
})
export class AllLectureMenuComponent implements OnInit {

  @Output()
  emitLectureNumber: EventEmitter<string> = new EventEmitter();

  constructor() { }

  ngOnInit(): void {
  }

  // w tym komponencie bedzie lista wszystkich lekcji, wybierajac jakas bedzie przekazywane
  // outputem i eventemiterme string lub number z numerem lekcji, wg ktorego kolejne komponenty
  // beda pobierac z api odpowiednie dane do lekcji

  GetLecture(lectureNumber: string): void
  {
    console.log(lectureNumber);
    this.emitLectureNumber.emit(lectureNumber);
  }

}
