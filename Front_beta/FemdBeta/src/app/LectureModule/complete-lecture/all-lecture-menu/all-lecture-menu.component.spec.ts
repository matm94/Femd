import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllLectureMenuComponent } from './all-lecture-menu.component';

describe('AllLectureMenuComponent', () => {
  let component: AllLectureMenuComponent;
  let fixture: ComponentFixture<AllLectureMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllLectureMenuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AllLectureMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
