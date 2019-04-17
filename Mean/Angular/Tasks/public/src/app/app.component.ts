import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'MEAN Tasks';
  tasks = []
  newTask: any;
  editTask: any;
  deleteId: number;
  selectedTask: any;

  constructor(private _httpService: HttpService){}

  ngOnInit(){
    this.getTasksFromService();
    this.newTask = {title: "", description: ""};
    this.editTask = {title:"", description:""}
  }

  getTasksFromService(){
    let observable = this._httpService.getTasks();
    observable.subscribe(data =>{
      
      console.log("Got our Tasks!", data)
      this.tasks = data['tasks'];
    });
    
  }

  addTask(){
    let observable = this._httpService.addTask(this.newTask);
    observable.subscribe(data => {
      console.log("Adding Task", data);
      this.getTasksFromService();
    })
    this.newTask = {title: "", description: ""}
  }

  deleteTask(id: number){
    console.log(id)
    let observable = this._httpService.deleteTask(id);
    observable.subscribe(data => {
      console.log("Deleteing Task from component", data);
      this.getTasksFromService();
    })
  }

  showEditTask(task){
    console.log(task);
    this.editTask = task;
    console.log(this.editTask);
  }

  updateTask(){
    console.log("EDITING TASK");
    let observable = this._httpService.updateTask(this.editTask);
    observable.subscribe(data => {
      console.log("Updating Task", data);
      this.getTasksFromService();

    })
  }

  showTask(task){
    console.log(task);
    this.selectedTask = task;
    // let observable = this._httpService.showTask(this.taskToShow)
  }
}
