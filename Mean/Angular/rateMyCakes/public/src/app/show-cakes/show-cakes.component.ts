import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from '../http.service'
import { log } from 'util';

@Component({
  selector: 'app-show-cakes',
  templateUrl: './show-cakes.component.html',
  styleUrls: ['./show-cakes.component.css']
})
export class ShowCakesComponent implements OnInit {

  @Input() showCakes: any;
  constructor(private _httpService: HttpService) { }

  showThisCake: any;
  rateThisCake: any;
  
  ngOnInit() {
    this.showAllCakes();
  }

  showAllCakes(){
    console.log("Getting Cakes From Component");
    let observable = this._httpService.getCakes();
    observable.subscribe(data => {
      console.log("Got Cakes", data);
      this.showCakes = data;
      console.log("ALL CAKES", this.showCakes);
    })
  }

  showCake(cake){
    console.log(cake);
    this.rateThisCake = undefined;
    this.showThisCake = cake;
  }

  showRateCake(cake){
    console.log(cake);
    this.showThisCake = undefined;
    this.rateThisCake = cake;
  }

}
