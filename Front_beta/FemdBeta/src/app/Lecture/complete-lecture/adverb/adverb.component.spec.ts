import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { AdverbComponent } from './adverb.component';

describe('AdverbComponent', () => {
  let component: AdverbComponent;
  let fixture: ComponentFixture<AdverbComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ AdverbComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdverbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
