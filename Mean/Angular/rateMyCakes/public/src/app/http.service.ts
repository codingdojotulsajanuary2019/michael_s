import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {}
  // CREATE METHODS HERE
  addCake(cake){
    console.log("Adding From Service", cake);
    return  this._http.post("/new", cake);
  }

  getCakes(){
    console.log("Getting Cakes From Service");
    return this._http.get("/all/cakes");
  }

  rateThisCake(cake){
    return this._http.put('/update', cake);
  }

}
