import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Ninja Gold';
  score : Number;
  name : String = "";
  errMessage: String = "";
  history = [];
  status = false;
  Id : String = ""

  constructor(private _httpService: HttpService){}
  ngOnInit(){}

  player(event){
    if(event.key.length <= 1 ){
      console.log(event.key);
      this.name += event.key;
    }
  }
  ready(){
    if(this.name == ""){
      this.errMessage = "Please provide a Name";
    }
    else{
      console.log(this.name);
      let playerName = {name: this.name};

      let tempObserevable = this._httpService.createGame(playerName);
      tempObserevable.subscribe(data => {
        this.name = data["game"]["name"];
        this.score = data["game"]["score"];
        this.status = true;
        this.Id = data['game']['_id'];
      })
    }
  }

  update(place : String){
    let newScore: number = 0;
    let gameId = this.Id
    if(place == "farm"){
      newScore = Math.floor(Math.random() * 20) + 10 
    }
    
    else if(place == "cave"){
      newScore = Math.floor(Math.random() * 10) + 5 
    }
    
    else if(place == "house"){
      newScore = Math.floor(Math.random() * 5) + 2
    }
    
    else if(place == "casino"){
      newScore = Math.floor(Math.random() * 50) - 50
    }
    console.log(this.Id);
    let tempObserevable = this._httpService.updateGame(gameId, newScore);
      tempObserevable.subscribe(data => {
        console.log(data)
        this.score = data["game"]["score"];
      })
  }
}
