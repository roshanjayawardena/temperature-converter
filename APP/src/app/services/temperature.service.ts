import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { TempratureModel } from '../models/temperature.model';

@Injectable({
  providedIn: 'root'
})
export class TemperatureService {

  constructor(private http: HttpClient) { }

 getConvertedTempValues(
    tempValue: string,
    type: number
  ): Observable<TempratureModel> {
    return this.http.get<TempratureModel>(
      `${environment.baseEndPoint}/Temperature/GetTemperatureValues/${type}/${tempValue}`,
      
    );
  }

}
