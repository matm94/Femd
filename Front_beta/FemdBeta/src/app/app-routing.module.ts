import { UserProfileComponent } from './home/user-profile/user-profile.component';
import { ProfileSettingsComponent } from './home/profile-settings/profile-settings.component';
import { TopTenComponent } from './home/top-ten/top-ten.component';
import { QuizComponent } from './home/quiz/quiz.component';
import { LessonsComponent } from './home/lessons/lessons.component';
import { WordsComponent } from './home/words/words.component';
import { RepeatsComponent } from './home/repeats/repeats.component';
import { NewLessonComponent } from './home/new-lesson/new-lesson.component';
import { AuthGuard } from './auth/auth.guard';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegistrationComponent } from './User/registration/registration.component';
import { UserComponent } from './user/user.component';
import { LoginComponent } from './user/login/login.component';
import { HomeComponent } from './home/home.component';
import { AdjectiveComponent } from './Lecture/adjective/adjective.component';
import { PictureModuleComponent } from './lecture/picture-module/picture-module.component';
import { WordsDictionaryComponent } from './Lecture/words-dictionary/words-dictionary.component';
import { TextfieldComponent } from './lecture/textfield/textfield.component';
import { CompleteLectureComponent } from './Lecture/complete-lecture/complete-lecture.component';


const routes: Routes = [
  {
    path: '', redirectTo: '/user/login', pathMatch: 'full'
  },
  {
    path: 'user', component: UserComponent,
    children: [
      {
        path: 'registration', component: RegistrationComponent
      },
      {
        path: 'login', component: LoginComponent,
      }
    ]
  },
  {
    path: 'home', component: HomeComponent, canActivate: [AuthGuard],
  },
  {
    path: 'newLesson', component: NewLessonComponent, canActivate: [AuthGuard],
  },
  {
    path: 'repeats', component: RepeatsComponent, canActivate: [AuthGuard],
  },
  {
    path: 'words', component: WordsComponent, canActivate: [AuthGuard],
  },
  {
    path: 'lessons', component: LessonsComponent, canActivate: [AuthGuard],
  },
  {
    path: 'quiz', component: QuizComponent, canActivate: [AuthGuard],
  },
  {
    path: 'topTen', component: TopTenComponent, canActivate: [AuthGuard],
  },
  {
    path: 'settings', component: ProfileSettingsComponent, canActivate: [AuthGuard],
  },
  {
    path: 'userProfile', component: UserProfileComponent, canActivate: [AuthGuard],
  },
  {
    path: 'adjective', component: AdjectiveComponent, canActivate: [AuthGuard],
  },
  {
    path: 'textfield', component: TextfieldComponent, canActivate: [AuthGuard],
  },
  {
    path: 'picture-module', component: PictureModuleComponent, canActivate: [AuthGuard],
  },
  {
    path: 'words-dictionary', component: WordsDictionaryComponent, canActivate: [AuthGuard],
  },
  {
    path: 'complete-lecture', component: CompleteLectureComponent, canActivate: [AuthGuard],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
