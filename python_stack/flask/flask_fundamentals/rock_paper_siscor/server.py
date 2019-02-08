from flask import Flask, render_template, session, redirect, request
from random import randint

app = Flask(__name__)
app.secret_key = "our secret key"


@app.route('/')
def home():

    return render_template('index.html')

@app.route('/game', methods=['POST'])
def game():
    print("*"*80)
    print("GOT REQUEST FORM")
    print("*"*80)
    print(request.form)

    session['choice'] = request.form['choice']
    

    computer_choice = randint(1,3)
    print("!"*80)
    print(computer_choice)


    if computer_choice == 1 and session['choice'] == "Rock":
        print('$'*80)
        print("Computer Chose Rock")
        print("User Chose Rock")
        print("TIE!")
        session['comp_choice'] = "Rock"
        session['result'] = "TIE"

    if computer_choice == 1 and session['choice'] == "Paper":
        print("Computer Chose Rock")
        print("User Chose Paper")
        print("USER WINS!")
        session['comp_choice'] = "Rock"
        session['result'] = "USER WINS"

    if computer_choice == 1 and session['choice'] == "Scissor":
        print("Computer Chose Rock")
        print("User Chose Scissor")
        print("COMPUTER WINS!")
        session['comp_choice'] = "Rock"
        session['result'] = "COMPUTER WINS"

    if computer_choice == 2 and session['choice'] == "Paper":
        print('$'*80)
        print("Computer Chose Paper")
        print("User Chose Paper")
        print("TIE!")
        session['comp_choice'] = "Paper"
        session['result'] = "IT'S A TIE!"

    if computer_choice == 2 and session['choice'] == "Scissor":
        print("Computer Chose Paper")
        print("User Chose Scissor")
        print("USER WINS!")
        session['comp_choice'] = "Paper"
        session['result'] = "USER WINS!"

    if computer_choice == 2 and session['choice'] == "Rock":
        print("Computer Chose Paper")
        print("User Chose Rock")
        print("COMPUTER WINS!")
        session['comp_choice'] = "Paper"
        session['result'] = "COMPUTER WINS"

    if computer_choice == 3 and session['choice'] == "Scissors":
        print('$'*80)
        print("Computer Chose Scissors")
        print("User Chose Scissors")
        print("TIE!")
        session['comp_choice'] = "Scissors"
        session['result'] = "IT'S A TIE!"

    if computer_choice == 3 and session['choice'] == "Rock":
        print("Computer Chose Scissors")
        print("User Chose Rock")
        print("USER WINS!")
        session['comp_choice'] = "Scissors"
        session['result'] = "USER WINS!"
        
    if computer_choice == 3 and session['choice'] == "Paper":
        print("Computer Chose Scissors")
        print("User Chose Paper")
        print("COMPUTER WINS!")
        session['comp_choice'] = "Scissors"
        session['result'] = "COMPUTER WINS!"
   
        





    return redirect('/game_result')

@app.route('/game_result')
def game_result():
    print('#'*80)
    print(*"RETURNING RESULTS")

    return render_template('result.html')







if __name__ == "__main__":
    app.run(debug=True)
