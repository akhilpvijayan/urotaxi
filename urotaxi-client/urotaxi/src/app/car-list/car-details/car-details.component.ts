import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.scss']
})
export class CarDetailsComponent implements OnInit {
id:string | null = '';
  constructor(private _Activatedroute:ActivatedRoute) {
    this._Activatedroute.paramMap.subscribe(paramMap => { 
    this.id = paramMap.get('id'); 
}); }

  ngOnInit(): void {
    console.log(this.id);
  }

  onSubmit(form: NgForm){

  }
}
