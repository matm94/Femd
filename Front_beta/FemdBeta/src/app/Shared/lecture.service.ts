import { PersonalPronoun } from 'src/app/Models/PersonalPronoun';
import { CompleteLecture } from './../Models/CompleteLecture';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Lecture } from '../Models/Lecture';
import { Verb } from '../Models/Verb';

@Injectable({
  providedIn: 'root'
})
export class LectureService {

  constructor(private http: HttpClient) { }

  private LectureURL = 'https://localhost:44366/api/Lecture/name/Hello';
  private CompleteLectureURL = 'https://localhost:44366/api/Lecture/CompleteLecture/715500d6-27fc-4112-865c-08d89c755f86';
  private AdjectiveURL = 'https://localhost:44366/api/Lecture/Adjective/f9dc5779-d5f3-4256-eefe-08d89c755f94';
  private AdverbURL = 'https://localhost:44366/api/Lecture/Adverb/338802d0-1372-49f7-eeff-08d89c755f94';
  private NounURL = 'https://localhost:44366/api/Lecture/Noun/7db6f43f-b64a-4ba6-ef00-08d89c755f94';
  private PersonalPronounURL = 'https://localhost:44366/api/Lecture/PersonalPronoun/7ed41bed-5f1e-43e5-dbc3-08d89c755f9b';
  private SentenceURL = 'https://localhost:44366/api/Lecture/Sentence/11640f5e-399f-4338-ef04-08d89c755f94';
  private VerbURL = 'https://localhost:44366/api/Lecture/Verb/b5d61659-0a6b-4448-1683-08d89c755fa0';

  getLecture(): Observable<Lecture>
  {
    return this.http.get<Lecture>(this.LectureURL);
  }
  // tslint:disable-next-line: typedef
  getCompleteLecture(): Observable<CompleteLecture>
  {
    return this.http.get<CompleteLecture>(this.CompleteLectureURL);
  }

  getAdjective(): Observable<PartsOfSpeech>
  {
    return this.http.get<PartsOfSpeech>(this.AdjectiveURL);
  }

  getAdverb(): Observable<PartsOfSpeech>
  {
    return this.http.get<PartsOfSpeech>(this.AdverbURL);
  }

  getNoun(): Observable<PartsOfSpeech>
  {
    return this.http.get<PartsOfSpeech>(this.NounURL);
  }

  getPerspnalPronoun(): Observable<PersonalPronoun>
  {
    return this.http.get<PersonalPronoun>(this.PersonalPronounURL);
  }

  getSentence(): Observable<PartsOfSpeech>
  {
    return this.http.get<PartsOfSpeech>(this.SentenceURL);
  }

  getVerb(): Observable<Verb>
  {
    return this.http.get<Verb>(this.VerbURL);
  }
}
