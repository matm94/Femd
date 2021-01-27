import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WordsModuleComponent } from './words-module.component';

describe('WordsModuleComponent', () => {
  let component: WordsModuleComponent;
  let fixture: ComponentFixture<WordsModuleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WordsModuleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WordsModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
