import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import {  Task  } from 'src/app/Models/Task';

@Injectable({
  providedIn: 'root'
})
export class TasksService {


  private tasksList: Array<Task> = [];
  private doneTasks: Array<Task> = [];

  private tasksListObs = new BehaviorSubject<Array<Task>>([]);
  private tasksDoneObs = new BehaviorSubject<Array<Task>>([]);

  constructor() {

    this.tasksList = [
      { name: 'Nauka angulara', created: new Date()},
      { name: 'kodzenie w C#', created: new Date()},
      { name: 'Ogarniecie aplikacji', created: new Date()}
    ];
    this.tasksListObs.next(this.tasksList);
  }

  dodaj(task: Task) {
    this.tasksList.push(task);
    this.tasksListObs.next(this.tasksList);
  }
  usun(task: Task) {
    this.tasksList = this.tasksList.filter(e => e !== task);
    this.tasksListObs.next(this.tasksList);
  }

  zrobione(task: Task) {
    this.doneTasks.push(task);
    this.usun(task);
    this.tasksDoneObs.next(this.doneTasks);
  }

  getTasksListObs(): Observable<Array<Task>>{
    return this.tasksListObs.asObservable();
  }
  grtTasksDoneObs(): Observable<Array<Task>>{
    return this.tasksDoneObs.asObservable();
  }
}
