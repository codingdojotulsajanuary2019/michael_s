import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {
    // this. do something
   }
  // CREATE METHODS HERE
   getAllAuthors(){
    return this._http.get('/api/authors');
   }

   addAuthor(author){
    return this._http.post('/api/new', {name: author});
  }

  deleteAuthor(id){
    return this._http.delete(`/api/delete/${id}`);
  }

  getAuthor(id){
    return this._http.get(`/api/authors/${id}`);
  }

  updateAuthor(id, author){
    return this._http.put(`/authors/update/${id}`, author);
  }

}
