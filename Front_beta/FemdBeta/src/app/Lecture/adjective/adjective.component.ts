import { LectureRouterServiceService } from './../../Shared/lecture-router-service.service';
import { Component, OnInit } from '@angular/core';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';
import { LectureService } from 'src/app/Shared/lecture.service';
import { FormControl, FormGroup, FormBuilder, Validators, ValidatorFn, AbstractControl } from '@angular/forms';
import { Content } from '@angular/compiler/src/render3/r3_ast';

@Component({
  selector: 'app-adjective',
  templateUrl: './adjective.component.html',
  styleUrls: ['./adjective.component.css']
})
export class AdjectiveComponent implements OnInit {

  constructor(public lectureService: LectureService, private fb: FormBuilder, private router: LectureRouterServiceService) { }

  adjectives = new Array<PartsOfSpeech>();
  public fakeAdjective = new Array<PartsOfSpeech>
  (
    new PartsOfSpeech('drogi', 'teuer', 'sdfsdf'),

  );
  newContentList = Array<string>();
  newContent: string;
  correctWord: string;
  incorrectWord: string;


  adjectiveForm = this.fb.group({
    content: ['', [Validators.required]],
  });

  ngOnInit(): void {
  }

  goPictures(): void
  {
    this.router.goToPictures();
  }

   ValidateWord(content: string): boolean  {

    const correctContent = this.fakeAdjective.find( e => e.Content === content);
    if ( correctContent.Content !== undefined)
      {

          console.log(correctContent.Content + 'content znaleziony w bazie');
          console.log(correctContent.Translation + 'content znaleziony w bazie');
      }
      else if (correctContent.Content === undefined)
      {
          console.log('wszedl false do validatora');
          return false;
      }
  }

  CheckWord(): string
  {
    const correctWord = this.ValidateWord(this.newContent);
    if (correctWord === undefined)
    {
      console.log('validator');
      return this.incorrectWord = 'Słowo' + this.newContent + 'niepoprawne';
    }
    else
    {
      console.log(this.newContent + ' content poprawny' );
    }
  }

  onSubmit(): void
  {
    this.newContentList.push(this.newContent);
    console.log('onSubmit dziala');
  }
  Valid(): void
  {
    this.CheckWord();
  }

  clear(): void
  {
    this.adjectiveForm.reset();
  }
  getAdjective(): void
  {
    this.lectureService.getAdjective()
        .subscribe( data =>
          {
            console.log(data);
            this.adjectives = [data].map(item =>
              {
                  return new PartsOfSpeech(
                    item.translation,
                    item.content,
                    item.photoPath,
                  );
              });
          });
  }
}
