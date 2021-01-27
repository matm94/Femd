import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CompleteLectureComponent } from './complete-lecture.component';

describe('CompleteLectureComponent', () => {
  let component: CompleteLectureComponent;
  let fixture: ComponentFixture<CompleteLectureComponent>;

  beforeEach(async(() => {
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
