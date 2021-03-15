import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { VerbComponent } from './verb.component';

describe('VerbComponent', () => {
  let component: VerbComponent;
  let fixture: ComponentFixture<VerbComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ VerbComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VerbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
