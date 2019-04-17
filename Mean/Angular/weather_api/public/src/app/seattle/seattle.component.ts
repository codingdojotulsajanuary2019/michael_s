import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-seattle',
  templateUrl: './seattle.component.html',
  styleUrls: ['./seattle.component.css']
})
export class SeattleComponent implements OnInit {

  constructor(private _httpService: HttpService) { }
  city = "seattle";
  weather: any;
  iconCode: any;
  temp: number;
  high: number;
  low: number;

  ngOnInit() {
    this.getSeattleWeather(this.city)
  }

  getSeattleWeather(city){
    let observable = this._httpService.getWeather(city);
    observable.subscribe(data => {
      console.log("GOT SEATTLE WEATHER", data);
      this.weather = data;
      this.iconCode = data['weather'][0]['icon']
      this.temp = data['main']['temp']
      this.high = data['main']['temp_max']
      this.low = data['main']['temp_min']
      
    })
  }

}
