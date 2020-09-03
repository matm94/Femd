import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WykonaneZadaniaComponent } from './wykonane-zadania.component';

describe('WykonaneZadaniaComponent', () => {
  let component: WykonaneZadaniaComponent;
  let fixture: ComponentFixture<WykonaneZadaniaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WykonaneZadaniaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WykonaneZadaniaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
