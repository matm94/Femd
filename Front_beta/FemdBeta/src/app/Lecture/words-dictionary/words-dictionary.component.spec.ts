import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WordsDictionaryComponent } from './words-dictionary.component';

describe('WordsDictionaryComponent', () => {
  let component: WordsDictionaryComponent;
  let fixture: ComponentFixture<WordsDictionaryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WordsDictionaryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WordsDictionaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
