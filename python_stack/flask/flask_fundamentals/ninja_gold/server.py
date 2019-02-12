from flask import Flask, session, redirect, render_template, request
from random import randint

app = Flask(__name__)
app.secret_key = "top secret"


@app.route('/')
def home():
    session['gold_count'] = 0
    print(session['gold_count'])

    

    return render_template("index.html", gold_count = session['gold_count'])


@app.route('/process_money', methods=['POST'])
def process_money():

    if request.form == 'farm':
        session['gold_count'] += 1
    
    return redirect("/")

@app.route("/destroy", methods=['POST'])
def destroy():
    session.clear()
    
    return redirect('/')

if __name__ == "__main__":
    app.run(debug=True)