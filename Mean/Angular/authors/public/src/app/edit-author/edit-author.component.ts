import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service'
import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-edit-author',
  templateUrl: './edit-author.component.html',
  styleUrls: ['./edit-author.component.css']
})
export class EditAuthorComponent implements OnInit {

  constructor(
    private _http: HttpService,
    private _route: ActivatedRoute,
    private _router: Router) { }

  author: string
  id: any;
  nameToUpdate:string;
  errors = { }
  ngOnInit() {
    this._route.params.subscribe((params: Params)=>{
      this.id = params['id'];
    })
    this.getAuthor(this.id);
  }

  getAuthor(id){
    let author = this._http.getAuthor(id);
    author.subscribe(data => {
      console.log(data);
      this.author = data['author'][0];
      this.nameToUpdate = data['author'][0]['name']
    })
  }

  updateAuthor(id = this.id, author = this.author){
    console.log("AUTHOR", author)
    console.log("ID:", id)
    author['name'] = this.nameToUpdate
    console.log("SHOULD BE UPDATED", author);
    let update = this._http.updateAuthor(id, author);
    update.subscribe(data => {
      console.log("UPDATE:", data);
      if(data['success']==false){
        this.errors['name'] =  data['error']['errors']['name'].message
      }
    })
  }

}
