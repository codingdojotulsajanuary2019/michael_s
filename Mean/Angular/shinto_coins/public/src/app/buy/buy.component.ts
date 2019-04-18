import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-buy',
  templateUrl: './buy.component.html',
  styleUrls: ['./buy.component.css']
})
export class BuyComponent implements OnInit {

  currentInfo: any;
  amount: number = 0;

  constructor(private _http: HttpService) { }

  ngOnInit() {
    this.getCurrentInfo();
  }

  getCurrentInfo(){
    this.currentInfo = this._http.sendInfoToBuyComp()
    console.log("CURRENT INFO", this.currentInfo);
  }

  buyCoins(amount = this.amount){
    this._http.buyCoins(amount);
    this.getCurrentInfo();
  }

}
