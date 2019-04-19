import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  allAuthors: any = [];
  constructor(private _http: HttpService) { }

  ngOnInit() {
    this.getAllAuthors();
  }

  getAllAuthors(){
    console.log("Getting All Authors")
    let allAuthors = this._http.getAllAuthors();
    allAuthors.subscribe(data => {
      console.log("Got Authors", data);
      this.allAuthors = data['authors'];
    })

  }

  deleteAuthor(id){
    let deleteAuthor = this._http.deleteAuthor(id);
    deleteAuthor.subscribe(data => {
      console.log(data);
      this.getAllAuthors();
    })
  }

}
