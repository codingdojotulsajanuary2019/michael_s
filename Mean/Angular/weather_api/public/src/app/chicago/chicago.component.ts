import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-chicago',
  templateUrl: './chicago.component.html',
  styleUrls: ['./chicago.component.css']
})
export class ChicagoComponent implements OnInit {

  constructor(private _httpService: HttpService) { }
  city = "chicago";
  weather: any;
  iconCode: any;
  temp: number;
  high: number;
  low: number;

  ngOnInit() {
    this.getChicagoWeather(this.city)
  }

  getChicagoWeather(city){
    let observable = this._httpService.getWeather(city);
    observable.subscribe(data => {
      console.log("GOT CHICAGO WEATHER", data);
      this.weather = data;
      this.iconCode = data['weather'][0]['icon']
      this.temp = data['main']['temp']
      this.high = data['main']['temp_max']
      this.low = data['main']['temp_min']
      
    })
  }

}
