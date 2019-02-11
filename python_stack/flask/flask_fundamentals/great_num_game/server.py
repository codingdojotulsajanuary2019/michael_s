from flask import Flask, render_template, redirect, request, session
from random import randint

app = Flask(__name__)
app.secret_key = "TOP SECRET"

computer_num = randint(1, 100)
high = "TOO HIGH"
low = "TOO LOW"
win = "YOU GUESSED RIGHT!"


@app.route("/")
def home():
    print("*"*80)
    print(computer_num)
    print("*"*80)

    return render_template("home.html")


@app.route("/user_guess", methods=['POST'])
def user_guess():
    session['user_guess'] =  request.form['user_guess']
    print(session['user_guess'])

    return redirect("/")




# @app.route("/destroy", methods = ['POST'])
# def destroy_session():
#     session.clear()

#     return redirect("/")



if __name__ == "__main__":
    app.run(debug=True)
