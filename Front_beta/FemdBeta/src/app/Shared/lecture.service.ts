import { Lecture } from './../Models/Lecture';
import { PersonalPronoun } from 'src/app/Models/PersonalPronoun';
import { CompleteLecture } from './../Models/CompleteLecture';
import { PartsOfSpeech } from 'src/app/Models/PartsOfSpeech';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Verb } from '../Models/Verb';

@Injectable({
  providedIn: 'root'
})
export class LectureAPIService {

  constructor(private http: HttpClient) { }

  private LectureURL = 'https://localhost:44366/api/Lecture/name/Hello';
  private LectureAll = 'https://localhost:44366/api/Lecture/All';
  private CompleteLectureURL = 'https://localhost:44366/api/Lecture/CompleteLecture/5de4ed93-51a3-4910-9d2c-29177d0c5a14';

  getLecture(): Observable<Lecture>
  {
    return this.http.get<Lecture>(this.LectureURL);
  }

  getAllLecture(): Observable<Lecture>
  {
    return this.http.get<Lecture>(this.LectureAll);
  }

  getCompleteLecture(lectureNumberFromuser: string): Observable<CompleteLecture>
  {
    // zmienic scieżke do api, uwzgledniajaca mozliwosc zmiany numeru lekcji przy zapytaniu
    return this.http.get<CompleteLecture>(this.CompleteLectureURL);
  }
}
