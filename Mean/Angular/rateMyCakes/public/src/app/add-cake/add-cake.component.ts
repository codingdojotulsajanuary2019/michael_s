import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-add-cake',
  templateUrl: './add-cake.component.html',
  styleUrls: ['./add-cake.component.css']
})
export class AddCakeComponent implements OnInit {

  @Input() addCake: any;
  constructor(private _httpService: HttpService) { }

  ngOnInit() {
  }
  
  createCake(){
    console.log(`Adding From Component`, this.addCake);
    let observable = this._httpService.addCake(this.addCake);
    observable.subscribe(data => {
      console.log('Adding Cake', data)
    })
    this.addCake = {baker: "", image: ""}
  }
}
