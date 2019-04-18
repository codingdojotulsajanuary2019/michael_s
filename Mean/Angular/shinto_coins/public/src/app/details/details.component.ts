import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'
import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {

  id:number;
  transaction: any;
  constructor(
    private _http: HttpService,
    private _route: ActivatedRoute,
    private _router: Router
    ) { }

  ngOnInit() {

    this._route.params.subscribe((params: Params)=>{
      console.log(params['id']);
      this.id = params['id'];
      this.getTransaction(this.id);
    })
  }

  getTransaction(id = this.id){
    this.transaction = this._http.getTransaction(id);
    console.log("TRANSACTION", this.transaction);

  }

}
