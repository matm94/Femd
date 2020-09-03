import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import {  TasksService } from 'src/app/Services/tasks.service';
import {  Task  } from 'src/app/Models/Task';

@Component({
  selector: 'app-lista-zadan',
  templateUrl: './lista-zadan.component.html',
  styleUrls: ['./lista-zadan.component.css']
})
export class ListaZadanComponent implements OnInit {

  tasksList: Array<Task> = [];
  constructor(private TasksServices: TasksService) {
    this.TasksServices.getTasksListObs().subscribe( tasks => {
      this.tasksList = tasks.slice();
    });
   }

  ngOnInit() {
  }
  usun(task: Task) {
    this.TasksServices.usun(task);
  }
  zrobione(task: Task) {
    task.end = new Date();
    this.TasksServices.zrobione(task);
  }

}
