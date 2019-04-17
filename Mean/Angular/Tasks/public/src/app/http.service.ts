import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private _http: HttpClient) {

   }
  // CREATE METHODS HERE
  getTasks(){
    return this._http.get('/tasks');
  }

  addTask(newTask){
    console.log("Working Add Task")
    console.log(newTask);
    return this._http.post(`/new/${newTask.title}/${newTask.description}`, newTask);
  }

  deleteTask(id){
    console.log(`Deleting Task from service ${id['id']}`);
    return this._http.delete(`/tasks/delete/${id['id']}`, id);
  }


  updateTask(task){
    return this._http.put(`/tasks/update/${task['_id']}`, task);
  }
  

  // updateTask(){

  // }


  // getById(id:string){
  //   let getThisTask = this._http.get(`/tasks/find/${id}`);
  //   getThisTask.subscribe(data => console.log('GOT TASK', data))
  // }

}
