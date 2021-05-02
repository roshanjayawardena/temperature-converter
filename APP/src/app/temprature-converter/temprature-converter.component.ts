import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { TemperatureStatusEnum } from '../models/temperature.model';
import { TempratureCreateModel } from '../models/temprature-create.model';
import { TemperatureService } from '../services/temperature.service';

@Component({
  selector: 'app-temprature-converter',
  templateUrl: './temprature-converter.component.html',
  styleUrls: ['./temprature-converter.component.scss'],
})
export class TempratureConverterComponent implements OnInit {
  
  constructor(
  ) {}

  ngOnInit(): void {
   
  }
}
