import { Component, OnInit } from '@angular/core';
import { makeDecorator } from '@angular/core/src/util/decorators';

@Component({
  selector: 'app-car-edit',
  templateUrl: './car-edit.component.html',
  styleUrls: ['./car-edit.component.scss']
})
export class CarEditComponent implements OnInit {

  cars: Array<string>;
  features: Array<string>;
  constructor() { 
    this.cars = ["Make1", "Make2", "Make3"];
    this.features = ["Feature1", "Feature2", "Feature3"];
  }

  ngOnInit() {

  }

}
