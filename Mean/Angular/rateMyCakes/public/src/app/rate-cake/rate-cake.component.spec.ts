import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RateCakeComponent } from './rate-cake.component';

describe('RateCakeComponent', () => {
  let component: RateCakeComponent;
  let fixture: ComponentFixture<RateCakeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RateCakeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RateCakeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
