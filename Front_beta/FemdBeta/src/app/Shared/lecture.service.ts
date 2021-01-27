import { CompleteLecture } from '../Models/CompleteLecture';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

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

  getLecture(): Observable<any>
  {
    return this.http.get<any>(this.LectureURL);
  }
  // tslint:disable-next-line: typedef
  getCompleteLecture(): Observable<any>
  {
    return this.http.get<any>(this.CompleteLectureURL);
  }

  getAdjective(): Observable<any>
  {
    return this.http.get<any>(this.AdjectiveURL);
  }

  getAdverb(): Observable<any>
  {
    return this.http.get<any>(this.AdverbURL);
  }

  getNoun(): Observable<any>
  {
    return this.http.get<any>(this.NounURL);
  }

  getPerspnalPronoun(): Observable<any>
  {
    return this.http.get<any>(this.PersonalPronounURL);
  }

  getSentence(): Observable<any>
  {
    return this.http.get<any>(this.SentenceURL);
  }

  getVerb(): Observable<any>
  {
    return this.http.get<any>(this.VerbURL);
  }
}
