from flask import Flask, render_template, redirect, session, flash, request
from  mysqlconnection import connectToMySQL


app = Flask(__name__)
app.secret_key = "2Shea"

@app.route("/")
def show_form():

    return render_template("form.html")

@app.route("/submit", methods = ['POST'])
def submit_form():

    is_valid = True

    if len(request.form['firstname']) < 2:
        is_valid = False
        flash("Please enter a first name")
    if len(request.form['lastname']) < 2:
        is_valid = False
        flash("Please enter a last name")
    if len(request.form['location']) == None:
        is_valid = False
        flash("Please select a location")
    if len(request.form['favlang']) == None: 
        is_valid = False
        flash("Please select a favorite language")
    


    if is_valid:

        flash("FORM SUBMITED")

        mysql = connectToMySQL("survey_with_validation")

        query = "INSERT INTO users (first_name, last_name, dojo_location, favorite_language, comments) VALUES (%(fn)s, %(ln)s, %(loc)s, %(lang)s, %(com)s );"

        data  = {

            "fn" : request.form['firstname'],
            "ln" : request.form['lastname'],
            "loc" : request.form['location'],
            "lang" : request.form['favlang'],
            "com" : request.form['comment']

        }

        submit_info = mysql.query_db(query, data)


    return redirect("/")

@app.route("/result")
def show_result():



    return render_template('result.html',)


if __name__ == "__main__":
    app.run(debug=True)
