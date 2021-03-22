import { LectureAPIService } from './Shared/lecture.service';
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
import { CompleteLectureComponent } from './LectureModule/complete-lecture/complete-lecture.component';
import { WordsDictionaryComponent } from './LectureModule/complete-lecture/lecture/words-dictionary/words-dictionary.component';
import { PictureModuleComponent } from './LectureModule/complete-lecture/lecture/picture-module/picture-module.component';
import { WordsModuleComponent } from './LectureModule/complete-lecture/lecture/words-module/words-module.component';
import { TextfieldComponent } from './LectureModule/complete-lecture/lecture/textfield/textfield.component';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
import { AllLectureMenuComponent } from './LectureModule/complete-lecture/all-lecture-menu/all-lecture-menu.component';
import { LectureComponent } from './LectureModule/complete-lecture/lecture/lecture.component';



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
    PictureModuleComponent,
    WordsModuleComponent,
    TextfieldComponent,
    AllLectureMenuComponent,
    LectureComponent
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
    LectureAPIService,
    NavBarService,
    {
      provide : HTTP_INTERCEPTORS,
      useClass : AuthInterceptor,
      multi: true
    }],
  bootstrap: [AppComponent]
})
export class AppModule { }
