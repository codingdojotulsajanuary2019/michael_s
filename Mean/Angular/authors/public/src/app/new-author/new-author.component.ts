import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-new-author',
  templateUrl: './new-author.component.html',
  styleUrls: ['./new-author.component.css']
})
export class NewAuthorComponent implements OnInit {

  newAuthor: string;
  errors = {}

  constructor(private _http: HttpService) { }

  ngOnInit() {
    this.newAuthor = undefined
  }

  createAuthor(author=this.newAuthor){
    console.log(author);
    let observable = this._http.addAuthor(author);
    observable.subscribe(data => {
      console.log(data)
      if(data['success']==false){
        this.errors['name'] =  data['error']['errors']['name'].message
      }
    });
  }

}
