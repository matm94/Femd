import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { AdjectiveComponent } from './adjective.component';

describe('AdjectiveComponent', () => {
  let component: AdjectiveComponent;
  let fixture: ComponentFixture<AdjectiveComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ AdjectiveComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdjectiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
