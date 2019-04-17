import { Component, OnInit } from '@angular/core';
import { Key } from 'protractor';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-tulsa',
  templateUrl: './tulsa.component.html',
  styleUrls: ['./tulsa.component.css']
})
export class TulsaComponent implements OnInit {

  constructor(private _httpService: HttpService) { }
  city = "tulsa";
  weather: any;
  iconCode: any;
  temp: number;
  high: number;
  low: number;
  ngOnInit() {
    this.getTulsaWeather(this.city);
  }

  getTulsaWeather(city){
    let observable = this._httpService.getWeather(city);
    observable.subscribe(data => {
      console.log("GOT TULSA WEATHER", data);
      this.weather = data;
      this.iconCode = data['weather'][0]['icon']
      this.temp = data['main']['temp']
      this.high = data['main']['temp_max']
      this.low = data['main']['temp_min']
      
    })
  }

}
