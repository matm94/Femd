import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { PictureModuleComponent } from './picture-module.component';

describe('PictureModuleComponent', () => {
  let component: PictureModuleComponent;
  let fixture: ComponentFixture<PictureModuleComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ PictureModuleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PictureModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
