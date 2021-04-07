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
import { CompleteLectureComponent } from './LectureModule/complete-lecture/complete-lecture.component';
import { LectureComponent } from './LectureModule/complete-lecture/lecture/lecture.component';


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
    path: 'complete-lecture', component: CompleteLectureComponent, canActivate: [AuthGuard],
  },
  {
    path: 'lecture', component: LectureComponent, canActivate: [AuthGuard],
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
