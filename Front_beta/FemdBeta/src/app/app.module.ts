import { LectureService } from './Shared/lecture.service';
import { NavBarService } from './Shared/nav-bar.service';
import { AuthInterceptor } from './auth/auth.interceptor';
import { UserService } from './Shared/user.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './User/registration/registration.component';
import { MenuComponent } from './menu/menu.component';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';
import { NewLessonComponent } from './home/new-lesson/new-lesson.component';
import { RepeatsComponent } from './home/repeats/repeats.component';
import { WordsComponent } from './home/words/words.component';
import { LessonsComponent } from './home/lessons/lessons.component';
import { QuizComponent } from './home/quiz/quiz.component';
import { TopTenComponent } from './home/top-ten/top-ten.component';
import { UserProfileComponent } from './home/user-profile/user-profile.component';
import { ProfileSettingsComponent } from './home/profile-settings/profile-settings.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { CompleteLectureComponent } from './Lecture/complete-lecture/complete-lecture.component';
import { WordsDictionaryComponent } from './Lecture/words-dictionary/words-dictionary.component';
import { AdjectiveComponent } from './Lecture/adjective/adjective.component';
import { AdverbComponent } from './Lecture/adverb/adverb.component';
import { NounComponent } from './Lecture/noun/noun.component';
import { PersonalPronounComponent } from './Lecture/personal-pronoun/personal-pronoun.component';
import { SentenceComponent } from './Lecture/sentence/sentence.component';
import { VerbComponent } from './Lecture/verb/verb.component';
import { PictureModuleComponent } from './lecture/picture-module/picture-module.component';
import { WordsModuleComponent } from './lecture/words-module/words-module.component';
import { DictionaryModuleComponent } from './lecture/dictionary-module/dictionary-module.component';
import { TextfieldComponent } from './lecture/textfield/textfield.component';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';



@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    RegistrationComponent,
    MenuComponent,
    LoginComponent,
    HomeComponent,
    NewLessonComponent,
    RepeatsComponent,
    WordsComponent,
    LessonsComponent,
    QuizComponent,
    TopTenComponent,
    UserProfileComponent,
    ProfileSettingsComponent,
    NavBarComponent,
    CompleteLectureComponent,
    WordsDictionaryComponent,
    AdjectiveComponent,
    AdverbComponent,
    NounComponent,
    PersonalPronounComponent,
    SentenceComponent,
    VerbComponent,
    PictureModuleComponent,
    WordsModuleComponent,
    DictionaryModuleComponent,
    TextfieldComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production })
  ],
  providers: [
    UserService,
    LectureService,
    NavBarService,
    {
      provide : HTTP_INTERCEPTORS,
      useClass : AuthInterceptor,
      multi: true
    }],
  bootstrap: [AppComponent]
})
export class AppModule { }
