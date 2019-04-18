import { Injectable, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class HttpService implements OnInit{

  constructor(private _http: HttpClient) { }
  allQuestions: any;
  coins: number = 0;
  balance: number = 0;
  transactionNum: number = 1
  currentValue:number = 1
  entryAction: string;
  entryAmount: number;
  entry: any;
  ledger: Array<any> = [];
  
  
  ngOnInit(){
    this.loadQuestions();
    this.entry = {
      transaction_id: Number,
      action: String,
      amount: Number,
      value: Number,
    }
  }

  loadQuestions(){
    let observable = this._http.get('https://opentdb.com/api.php?amount=25&category=18&difficulty=medium&type=multiple');
    observable.subscribe(data => {
      this.allQuestions=data['results']
      console.log("QUESTIONS", this.allQuestions);
    })
  }

  getQuestion(index){
    return this.allQuestions[index];
  }

  correctAnswer(){
    console.log("CORRECT!")
    this.coins ++;
    this.entry = {
      transaction_id: this.transactionNum,
      action: "Mined",
      amount: 1,
      value: this.currentValue,
    }
    this.ledger.push(this.entry);
    this.transactionNum ++;
    this.balance +=  this.currentValue;
    this.currentValue ++;
    console.log("LEDGER", this.ledger);
    return this.balance;

  }

  sendInfoToBuyComp(){
    let info = {
      value: this.currentValue,
      coins: this.coins

    }
    return info;
  }

  getLedger(){
    return this.ledger;
  }

  buyCoins(amount){
    this.coins = this.coins + amount;
    this.entry = {
      transaction_id: this.transactionNum,
      action: "Buy",
      amount: amount,
      value: this.currentValue,
    }
    this.ledger.push(this.entry);
    this.transactionNum ++;
    this.balance +=  this.currentValue * amount;
    this.currentValue ++;
  }
  sellCoins(amount){
    this.coins  = this.coins - amount;
    this.entry = {
      transaction_id: this.transactionNum,
      action: "Sold",
      amount: amount,
      value: this.currentValue,
    }
    this.ledger.push(this.entry);
    this.transactionNum ++;
    this.balance -=  this.currentValue * amount;
    this.currentValue --;
  }

  getTransaction(id){
    return this.ledger[id-1];
  }
  
}
