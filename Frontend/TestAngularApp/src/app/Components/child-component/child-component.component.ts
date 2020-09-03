import { Component, OnInit, Input, Output, EventEmitter} from '@angular/core';



@Component({
  selector: 'app-child-component',
  templateUrl: './child-component.component.html',
  styleUrls: ['./child-component.component.css']
})
export class ChildComponentComponent implements OnInit {

  @Input() tasks: string;

  @Output()
  tasksevent = new EventEmitter<string>();


  constructor() { }

  ngOnInit() {
  }

  select(task){
    this.tasksevent.emit(task);
  }

}
