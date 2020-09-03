import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DodajZadanieComponent } from './dodaj-zadanie.component';

describe('DodajZadanieComponent', () => {
  let component: DodajZadanieComponent;
  let fixture: ComponentFixture<DodajZadanieComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DodajZadanieComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DodajZadanieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
