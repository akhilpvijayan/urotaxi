import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCarModelComponent } from './add-car-model.component';

describe('AddCarModelComponent', () => {
  let component: AddCarModelComponent;
  let fixture: ComponentFixture<AddCarModelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddCarModelComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddCarModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
