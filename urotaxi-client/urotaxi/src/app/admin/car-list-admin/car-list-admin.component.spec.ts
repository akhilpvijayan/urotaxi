import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarListAdminComponent } from './car-list-admin.component';

describe('CarListAdminComponent', () => {
  let component: CarListAdminComponent;
  let fixture: ComponentFixture<CarListAdminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CarListAdminComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarListAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
