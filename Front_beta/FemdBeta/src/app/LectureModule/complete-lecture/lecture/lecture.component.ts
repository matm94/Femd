import { Component, Input, OnInit } from '@angular/core';
import { connectableObservableDescriptor } from 'rxjs/internal/observable/ConnectableObservable';
import { CompleteLecture } from 'src/app/Models/CompleteLecture';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';
import { LectureRouterServiceService } from 'src/app/Shared/lecture-router-service.service';

@Component({
  selector: 'app-lecture',
  templateUrl: './lecture.component.html',
  styleUrls: ['./lecture.component.css']
})
export class LectureComponent implements OnInit {

  @Input()
  completeLectureApiData: CompleteLecture;

  adjectivesAPIData: PartsOfSpeech[];

  constructor(private router: LectureRouterServiceService) { }

  ngOnInit(): void {
    this.adjectivesAPIData = this.mapCompleteLectureAPIDataToAdjective(this.completeLectureApiData);
    console.log('Dane z CompleteLecture: ' + this.completeLectureApiData);
  }


  mapCompleteLectureAPIDataToAdjective(completeLectureApiData: CompleteLecture): PartsOfSpeech[]
  {
    if (completeLectureApiData === undefined || completeLectureApiData === null)
    {
      const adjectives = new PartsOfSpeech();
      // tslint:disable-next-line:prefer-const
      let adjectivesList: PartsOfSpeech[];
      this.completeLectureApiData.Adjectives.forEach(element => {
        adjectives.Content = element.Content;
        adjectives.Translation = element.Translation;
        adjectives.PhotoPath = element.PhotoPath;
        adjectivesList.push(adjectives);
        console.log(' mapToAdjective: ' + adjectives);
      });
      return adjectivesList;
    }

    console.log('completeLectureApiData ist undefined');

  }


  goAdjective(): void
  {
    this.router.goToWords();
  }

  goText(): void
  {
    this.router.goToTextArea();
  }
  goPictures(): void
  {
    this.router.goToPictures();
  }
  goDictionary(): void
  {
    this.router.goToAllWordsOfLecture();
  }

}
