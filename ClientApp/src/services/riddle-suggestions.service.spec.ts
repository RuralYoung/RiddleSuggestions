import { TestBed } from '@angular/core/testing';

import { RiddleSuggestionsService } from './riddle-suggestions.service';

describe('RiddleSuggestionsService', () => {
  let service: RiddleSuggestionsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RiddleSuggestionsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
