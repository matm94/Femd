import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import {  TasksService } from 'src/app/Services/tasks.service';
import {  Task  } from 'src/app/Models/Task';

@Component({
  selector: 'app-dodaj-zadanie',
  templateUrl: './dodaj-zadanie.component.html',
  styleUrls: ['./dodaj-zadanie.component.css']
})
export class DodajZadanieComponent implements OnInit {


  newTask: string;
  constructor( private TasksServices: TasksService) { }

  ngOnInit() {
  }

  dodaj() {
    const task: Task = {name: this.newTask, created: new Date()};
    this.TasksServices.dodaj(task);
    this.newTask = '';
  }
}
