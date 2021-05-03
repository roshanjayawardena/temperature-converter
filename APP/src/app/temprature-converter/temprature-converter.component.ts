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
  tempratureForm: FormGroup;
  tempratureCreateModel = new TempratureCreateModel();
  tempratureTypes: any[] = [
    { id: 1, status: 'Celsius' },
    { id: 2, status: 'Kelvin' },
    { id: 3, status: 'Fahrenheit' },
  ];

  celsius: number = 0;
  fahrenheit: number = 0;
  kelvin: number = 0;
  tempType: string;
  isConvert: boolean;
  tempStatusEnum = TemperatureStatusEnum;
  constructor(
    private fb: FormBuilder,
    private temperatureService: TemperatureService
  ) {}

  ngOnInit(): void {
    this.initializeForm();
  }

  initializeForm() {
    this.tempratureForm = this.fb.group({
      temprature: ['', [Validators.required]],
      tempratureType: ['', [Validators.required]],
    });
  }

  convert() {
    this.isConvert = true;
    this.tempratureCreateModel = Object.assign(
      {},
      this.tempratureCreateModel,
      this.tempratureForm.value
    );
    this.tempType = this.tempratureCreateModel.tempratureType;

    this.temperatureService.convertTemperatureValues(this.tempratureCreateModel).subscribe(
      (result) => {
        this.celsius = result.celsius;
        this.fahrenheit = result.fahrenheit;
        this.kelvin = result.kelvin;
      },
      (error) => {
       console.log(error);
      }
    );  
  } 

  get temprature() {
    return this.tempratureForm.get('temprature');
  }
  get tempratureType() {
    return this.tempratureForm.get('tempratureType');
  }
}
