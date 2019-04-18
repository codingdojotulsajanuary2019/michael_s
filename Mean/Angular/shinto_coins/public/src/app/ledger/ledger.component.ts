import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-ledger',
  templateUrl: './ledger.component.html',
  styleUrls: ['./ledger.component.css']
})
export class LedgerComponent implements OnInit {

  ledger: any;

  constructor(private _http: HttpService) { }

  ngOnInit() {
    this.getLedger();
  }

  getLedger(){
    this.ledger = this._http.getLedger();
    console.log("LEDGER", this.ledger);
  }

}
