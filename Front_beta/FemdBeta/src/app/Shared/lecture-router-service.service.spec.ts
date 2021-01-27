import { TestBed } from '@angular/core/testing';

import { LectureRouterServiceService } from './lecture-router-service.service';

describe('LectureRouterServiceService', () => {
  let service: LectureRouterServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LectureRouterServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
