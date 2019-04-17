import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'
import { stringify } from 'querystring';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {
    // this. do something
    this.getPokemon();
    
   }
  // CREATE METHODS HERE
  getPokemon(){
    let bulbasaur = this._http.get('https://pokeapi.co/api/v2/pokemon/1/');
    let name: string = "";
    let abilities: string = "Abilities: "
    bulbasaur.subscribe(data => {
      console.log(data);
      name += `Name: ${data['name']}`;
      for(var i in data['abilities']){
        abilities += `${data['abilities'][i]['ability']['name']}, `;
        let abilitiyUrl: string = data['abilities'][i]['ability']['url']
        this.findSimilar(abilitiyUrl)
      }
      
      console.log(name);
      console.log(abilities);
    }
  )}

  findSimilar(url: string){
    let similar = this._http.get(url);
    similar.subscribe(data => {
      console.log(`${data['pokemon'].length} Pokemon other pokemon have the ${data['name']} ability`);
    })
  }


}
