import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  newCake: any; 
  allCakes: any;

  constructor(private _httpService: HttpService){}
  ngOnInit(){
    this.newCake = {
      baker: "",
      image: "",
      rating:{stars: 0, comment:""}
    }
  }
  
}
