import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-sell',
  templateUrl: './sell.component.html',
  styleUrls: ['./sell.component.css']
})
export class SellComponent implements OnInit {

  currentInfo: any;
  amount: number = 0
  constructor(private _http: HttpService) { }
  ngOnInit() {
    this.getCurrentInfo()
  }

  getCurrentInfo(){
    this.currentInfo = this._http.sendInfoToBuyComp()
    console.log("CURRENT INFO", this.currentInfo);
  }

  sellCoins(amount = this.amount){
    this._http.sellCoins(amount);
    this.getCurrentInfo();
  }

}
