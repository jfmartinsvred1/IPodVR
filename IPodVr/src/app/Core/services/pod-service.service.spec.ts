import { TestBed } from '@angular/core/testing';

import { PodServiceService } from './pod-service.service';

describe('PodServiceService', () => {
  let service: PodServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PodServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
