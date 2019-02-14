from flask import Flask, render_template, redirect, request, session, flash
from sqlconnect import MySQLConnection
from flask_bcrypt import Bcrypt
import re

app = Flask(__name__)
app.secret_key = "2Shea"

bcrypt = Bcrypt(app)

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

@app.route("/")
def home():

    return render_template("login.html")

@app.route("/register", methods = ['POST'])
def register():
    is_valid = True

# ---------------------FIRST NAME VALIDATIONS
    if request.form['first_name'] == "" :
        is_valid = False
        flash(u"First Name field cannot be empty", "first_name")
    if request.form['first_name'] != "":
        if not str.isalpha(request.form['first_name']):
            is_valid = False
            flash(u"First Name can only contain letters", 'first_name')


# ---------------------LAST NAME VALIDATIONS
    if request.form['last_name'] == "":
        is_valid = False
        flash(u"Last Name field cannot be empty", "last_name")
    if request.form['last_name'] != "":
        if not str.isalpha(request.form['last_name']):
            is_valid = False
            flash(u"last Name can only contain letters", 'last_name')

# -----------------------EMAIL VALIDATIONS

    if request.form['email'] == "":
        is_valid = False
        flash(u"Email cannot be empty", "email")
    if request.form['email'] != "":
        if not EMAIL_REGEX.match(request.form['email']):
            is_valid = False
            flash(u"Invalid email address!", 'email')
        if EMAIL_REGEX.match(request.form['email']):
            
            mysql = MySQLConnection("login_registration")
            query = ("SELECT * FROM users WHERE email = %(email)s")
            data = {
                'email': request.form["email"]
            }
            email_valid = mysql.query_db(query, data)
            print(email_valid)

            if email_valid != ():
                is_valid = False
                print("INVALID")
                flash(f"{request.form['email']} is already taken", "email")



# ----------------------PASSWORD VALIDATIONS
    if request.form['password'] == "":
        is_valid = False
        flash(u"Password cannot be empty", "password")
    if request.form['password'] != "":
        if len(request.form['password']) < 8:
            is_valid = False
            flash(u"Password must be at least 8 characters long","password")
        if len(request.form['password']) >= 8:
            if request.form['password'] != request.form['password_confirm']:
                is_valid = False
                flash(u"Passwords entered must match", 'password')


# --------------------IF ALL VALIDATION PASS
    if is_valid:
        mysql = MySQLConnection('login_registration')

        query = "INSERT INTO users (first_name, last_name, email, password) VALUES (%(fn)s, %(ln)s, %(em)s, %(pw_hash)s);"
        print(query)

        pw_hash = bcrypt.generate_password_hash(request.form['password'])
        print("$"*80)
        print(pw_hash)
        print("$"*80)

        data = {
            "fn" : request.form['first_name'],
            "ln" : request.form['last_name'],
            "em" : request.form['email'],
            "pw_hash" : pw_hash
        }

        register_user = mysql.query_db(query, data)

        session['first_name'] = request.form['first_name']
        session['email'] = request.form['email']

        return redirect("/registersuccess")
    return redirect("/")

@app.route("/registersuccess")
def registration_success():

    return render_template("register_success.html")

@app.route("/login", methods = ['POST'])
def login():
    mysql = MySQLConnection("login_registration")
    query = "SELECT * FROM users WHERE email = %(email)s;"
    data = { "email" : request.form['login_email']}
    result = mysql.query_db(query, data)

    if result:
        if bcrypt.check_password_hash(result[0]['password'], request.form['password']):
            session['login_email'] = result[0]['email']
        return redirect("/login_success")

@app.route("/login_success")
def login_success():
    return render_template("login_success.html")

@app.route("/logout")
def logout():
    session.clear()

    return redirect("/")






if __name__ == "__main__":
    app.run(debug=True)
