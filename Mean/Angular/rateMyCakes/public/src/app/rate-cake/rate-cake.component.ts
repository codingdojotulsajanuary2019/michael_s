import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-rate-cake',
  templateUrl: './rate-cake.component.html',
  styleUrls: ['./rate-cake.component.css']
})
export class RateCakeComponent implements OnInit {

  @Input() cakeToRate: any;
  constructor(private _httpService: HttpService) { }

  ngOnInit() {
  }

  rateCake(){
    console.log("UPDATING FROM COMPONENT", this.cakeToRate)
    let observable = this._httpService.rateThisCake(this.cakeToRate);
    observable.subscribe(data => {
      console.log("Adding Rating", data);
    })
  }

}
