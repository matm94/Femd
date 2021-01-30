import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { RepeatsComponent } from './repeats.component';

describe('RepeatsComponent', () => {
  let component: RepeatsComponent;
  let fixture: ComponentFixture<RepeatsComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ RepeatsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RepeatsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
