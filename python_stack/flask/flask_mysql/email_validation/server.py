from flask import Flask, render_template, redirect, request, flash, session
from sqlconnect import connectToMySQL
import re

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

app = Flask(__name__)
app.secret_key = "2Shea"


@app.route("/")
def home():

    return render_template("form.html")

@app.route("/submit", methods = ['POST'])
def submit_email():

    is_valid = True
     # test whether a field matches the pattern
    if not EMAIL_REGEX.match(request.form['email']):
        is_valid = False
        flash("Invalid email address!")

    mysql = connectToMySQL("email_validation")

    query = ("SELECT * FROM emails WHERE email = %(email)s")

    data = {
        'email' : request.form["email"]
    }

    email_valid = mysql.query_db(query, data)
    print(email_valid) 

    if email_valid != ():
        is_valid = False
        print("INVALID")
        flash(f"The Email {request.form['email']} is already taken")
    
    



    if is_valid == True:

        flash(f"The email address you entered { request.form['email'] } is VALID!")

        mysql = connectToMySQL("email_validation")

        query = "INSERT INTO emails (email) values (%(email)s);"

        data = {
            'email' : request.form['email']
        }

        add_valid_email = mysql.query_db(query, data)

        return redirect("/success")

    return redirect("/")


@app.route("/success")
def success():

    mysql = connectToMySQL("email_validation")

    query = "SELECT id, email, date_format(created_at,  '%M %D %Y') as date FROM emails;"
    



    show_emails = mysql.query_db(query)

    print("#"*80)
    print(show_emails)
    print("#"*80)

    return render_template("success.html", show_emails = show_emails)

@app.route("/delete/<id>")
def delete(id):
    user_id = int(id)

    mysql = connectToMySQL("email_validation")

    query = "DELETE FROM emails WHERE id = %(id)s ; "

    data = {
        'id' : user_id
    }

    delete_email = mysql.query_db(query, data)

    return redirect("/success")




if __name__ == "__main__":
    app.run(debug=True)
