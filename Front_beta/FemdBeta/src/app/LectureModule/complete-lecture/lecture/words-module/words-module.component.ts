import { Component, Input, OnInit } from '@angular/core';
import { CompleteLecture } from 'src/app/Models/CompleteLecture';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';

@Component({
  selector: 'app-words-module',
  templateUrl: './words-module.component.html',
  styleUrls: ['./words-module.component.css']
})
export class WordsModuleComponent implements OnInit {

  @Input()
  adjectivesAPIDataWords: PartsOfSpeech[];

  constructor() { }

  ngOnInit(): void {
  }

}
