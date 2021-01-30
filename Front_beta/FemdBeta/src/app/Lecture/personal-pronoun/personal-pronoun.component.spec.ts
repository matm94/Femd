import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { PersonalPronounComponent } from './personal-pronoun.component';

describe('PersonalPronounComponent', () => {
  let component: PersonalPronounComponent;
  let fixture: ComponentFixture<PersonalPronounComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonalPronounComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonalPronounComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
