import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-dallas',
  templateUrl: './dallas.component.html',
  styleUrls: ['./dallas.component.css']
})
export class DallasComponent implements OnInit {

  constructor(private _httpService: HttpService) { }
  city = "dallas";
  weather: any;
  iconCode: any;
  temp: number;
  high: number;
  low: number;

  ngOnInit() {
    this.getDallasWeather(this.city)
  }

  getDallasWeather(city){
    let observable = this._httpService.getWeather(city);
    observable.subscribe(data => {
      console.log("GOT DALLAS WEATHER", data);
      this.weather = data;
      this.iconCode = data['weather'][0]['icon'];
      this.temp = data['main']['temp'];
      this.high = data['main']['temp_max'];
      this.low = data['main']['temp_min'];
      
    })
  }

}
