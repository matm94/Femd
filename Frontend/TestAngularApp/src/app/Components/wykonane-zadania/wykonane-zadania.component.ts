import { Component, OnInit, Input } from '@angular/core';
import {  TasksService } from 'src/app/Services/tasks.service';

@Component({
  selector: 'app-wykonane-zadania',
  templateUrl: './wykonane-zadania.component.html',
  styleUrls: ['./wykonane-zadania.component.css']
})
export class WykonaneZadaniaComponent implements OnInit {


  doneTasks = [];
  constructor(private TaskServices: TasksService) {
    this.TaskServices.grtTasksDoneObs().subscribe( tasks =>
      this.doneTasks = tasks);
   }

  ngOnInit() {
  }

}
