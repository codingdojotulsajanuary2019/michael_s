import { Component, OnInit, Input } from '@angular/core';
import { HttpService } from '../http.service'

@Component({
  selector: 'app-mine',
  templateUrl: './mine.component.html',
  styleUrls: ['./mine.component.css']
})
export class MineComponent implements OnInit {

  // @Input() balance: number;
  constructor(private _http: HttpService) { }
  question: any;
  questionIdx: number = 0;
  inncorrectAnswers: any;
  correctAnswer: string;
  selectedAnswer: any;
  currentBalance: number;



  ngOnInit() {
    this.getQuestion(this.questionIdx);
    // this.scramble_answers();
  }

  getQuestion(index){
    this.question = this._http.getQuestion(index);
    console.log("Question", this.question)
    this.inncorrectAnswers = this.question['incorrect_answers']
    console.log("INNCORECT ANSWS:", this.inncorrectAnswers);
    this.correctAnswer = this.question['correct_answer']
    console.log("CORRECT ANSWS:", this.correctAnswer);
    console.log("QUESTION IDX:", this.questionIdx);
  }
  
  answerCorrect(){
    this.inncorrectAnswers = undefined;
    this.correctAnswer = undefined;
    this.questionIdx ++;
    this.getQuestion(this.questionIdx);
    this.currentBalance = this._http.correctAnswer();
    console.log("BALANCE:", this.currentBalance)

  }

  answerInncorrect(){
    this.inncorrectAnswers = undefined;
    this.correctAnswer = undefined;
    this.questionIdx ++;
    this.getQuestion(this.questionIdx);
 
  }

  submitAnswer(answer){
    console.log(answer)
    if(answer[0] != this.correctAnswer){
      this.selectedAnswer = undefined;
      this.answerInncorrect();
    }
    else{
      this.selectedAnswer = undefined;
      this.answerCorrect();
    }
  }


}
