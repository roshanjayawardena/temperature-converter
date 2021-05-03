import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TempratureModel } from '../models/temperature.model';
import { TempratureCreateModel } from './../models/temprature-create.model';

@Injectable({
  providedIn: 'root'
})
export class TemperatureService {

  constructor(private http: HttpClient) { }


  convertTemperatureValues(tempCreateModel: TempratureCreateModel) {
    return this.http.post<TempratureModel>(
      `${environment.baseEndPoint}/Temperature/ConvertTemperature`,
      tempCreateModel
    );
  }

}
