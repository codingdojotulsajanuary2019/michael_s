from flask import Flask, render_template, request, redirect, session

app = Flask(__name__)
app.secret_key = 'my secret key'

@app.route("/")
def session_count():
    if 'add_session' in session:
        print("*"*80)
        print("KEY EXISTS!!!")
        print("*"*80)
        session['add_session'] += int(1)
    else:
        session['add_session'] = 1
        

    return render_template("counter.html")

    
@app.route("/countadd2")
def addtwo()

return redirect("/")



@app.route("/destroy")
def destroy():

    session.clear()

    return redirect("/")


if __name__ == "__main__":
    app.run(debug=True)
