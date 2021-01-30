import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { CompleteLectureComponent } from './complete-lecture.component';

describe('CompleteLectureComponent', () => {
  let component: CompleteLectureComponent;
  let fixture: ComponentFixture<CompleteLectureComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ CompleteLectureComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CompleteLectureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
