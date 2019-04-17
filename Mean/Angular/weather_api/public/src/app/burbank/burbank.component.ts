import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';

@Component({
  selector: 'app-burbank',
  templateUrl: './burbank.component.html',
  styleUrls: ['./burbank.component.css']
})
export class BurbankComponent implements OnInit {

  constructor(private _httpService: HttpService) { }
  city = "burbank";
  weather: any;
  iconCode: any;
  temp: number;
  high: number;
  low: number;

  ngOnInit() {
    this.getBurbankWeather(this.city);
  }

  getBurbankWeather(city){
    let observable = this._httpService.getWeather(city);
    observable.subscribe(data => {
      console.log("GOT BURBANK WEATHER", data);
      this.weather = data;
      this.iconCode = data['weather'][0]['icon']
      this.temp = data['main']['temp']
      this.high = data['main']['temp_max']
      this.low = data['main']['temp_min']
      
    })
  }

}
