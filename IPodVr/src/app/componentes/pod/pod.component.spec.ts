import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PodComponent } from './pod.component';

describe('PodComponent', () => {
  let component: PodComponent;
  let fixture: ComponentFixture<PodComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PodComponent]
    });
    fixture = TestBed.createComponent(PodComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
