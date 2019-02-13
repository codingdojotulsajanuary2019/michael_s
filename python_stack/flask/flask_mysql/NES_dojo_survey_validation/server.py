from flask import Flask, render_template, redirect, request, flash, session
from sqlconnect import connectToMySQL

app = Flask(__name__)
app.secret_key = "2Shea"

@app.route("/")
def display_form():


    return render_template("index.html")




if __name__ == "__main__":
    app.run(debug=True)