import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChildComponentComponent } from './components/child-component/child-component.component';
import { DodajZadanieComponent } from './Components/dodaj-zadanie/dodaj-zadanie.component';
import { ListaZadanComponent } from './Components/lista-zadan/lista-zadan.component';
import { WykonaneZadaniaComponent } from './Components/wykonane-zadania/wykonane-zadania.component';
import { TasksService } from './Services/tasks.service';
import { CheckedDirective } from './shared/checked.directive';
import { DateDirective } from './shared/date.directive';
import { TransformTaskPipe } from './Shared/transform-task.pipe';
import { SortNamePipe } from './shared/sort-name.pipe';

@NgModule({
  declarations: [
    AppComponent,
    ChildComponentComponent,
    DodajZadanieComponent,
    ListaZadanComponent,
    WykonaneZadaniaComponent,
    CheckedDirective,
    DateDirective,
    TransformTaskPipe,
    SortNamePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule

  ],
  providers: [TasksService],
  bootstrap: [AppComponent]
})
export class AppModule { }
