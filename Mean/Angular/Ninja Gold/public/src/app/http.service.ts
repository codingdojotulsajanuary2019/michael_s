import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {

  }
  // CREATE METHODS HERE
  // getTasks(){
  //   let tempObservable = this._http.get('/tasks');

  //   tempObservable.subscribe(data => console.log('got our tasks', data));
  // }

  createGame(name){
    return this._http.post('/ninjaGold', name);
  }

  updateGame(gameId: String, num : Number){
    console.log(gameId);
    return this._http.put(`/${gameId}`, {score: num})
  }

}
