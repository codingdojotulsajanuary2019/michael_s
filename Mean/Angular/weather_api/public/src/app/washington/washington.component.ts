import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-washington',
  templateUrl: './washington.component.html',
  styleUrls: ['./washington.component.css']
})
export class WashingtonComponent implements OnInit {

  constructor(private _httpService: HttpService) { }
  city = "washington";
  weather: any;
  iconCode: any;
  temp: number;
  high: number;
  low: number;

  ngOnInit() {
    this.getDCWeather(this.city);
  }

  getDCWeather(city){
    let observable = this._httpService.getWeather(city);
    observable.subscribe(data => {
      console.log("GOT WASHINGTON D.C. WEATHER", data);
      this.weather = data;
      this.iconCode = data['weather'][0]['icon']
      this.temp = data['main']['temp']
      this.high = data['main']['temp_max']
      this.low = data['main']['temp_min']
      
    })
  }

}
