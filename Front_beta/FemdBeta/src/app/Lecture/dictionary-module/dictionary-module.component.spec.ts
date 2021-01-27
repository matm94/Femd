import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DictionaryModuleComponent } from './dictionary-module.component';

describe('DictionaryModuleComponent', () => {
  let component: DictionaryModuleComponent;
  let fixture: ComponentFixture<DictionaryModuleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DictionaryModuleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DictionaryModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
