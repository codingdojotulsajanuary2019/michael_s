from flask import Flask, render_template, redirect, request
from usersmysqlconnect import connectToMySQL


app = Flask(__name__)


@app.route("/")
def home():

    return redirect("/users")

@app.route("/users")
def show_all_users():

    mysql = connectToMySQL("users_assignment")

    query = "SELECT id, first_name, last_name, email, created_at  FROM users;"


    show_users = mysql.query_db(query)

    return render_template ("users.html", user_table = show_users)

@app.route("/users/new/")
def show_add_user():

    return render_template("newUser.html")

@app.route("/user/create/new", methods = ["POST"])
def create_new_user():

    mysql =connectToMySQL("users_assignment")

    query = "INSERT INTO users (first_name, last_name, email) VALUES ( %(fn)s, %(ln)s, %(em)s );"

    data = {

        "fn" : request.form['first_name'],
        "ln" : request.form['last_name'],
        "em" : request.form['user_email']

    }

    add_new_user = mysql.query_db(query, data)

    return redirect("/users") 

@app.route("/user/<id>")
def show_user(id):
    user_id = int(id)

    mysql = connectToMySQL("users_assignment")

    query = "SELECT * from users WHERE id = %(id)s;"

    data =  {
        "id" : user_id
    }

    print(query)

    display_user = mysql.query_db(query, data)
    
    print(display_user)

    return render_template("showUSer.html", display_user = display_user)

@app.route("/user/<id>/edit")
def show_edit_user(id):
    user_id = int(id)

    mysql = connectToMySQL("users_assignment")

    query = "SELECT * from users WHERE id = %(id)s;"

    data = {
        'id' : user_id
    }

    display_info = mysql.query_db(query, data)



    return render_template("editUser.html", display_info = display_info)

@app.route("/user/<id>/update", methods=['POST'])
def update_user_info(id):

    mysql = connectToMySQL("users_assignment")

    query = "UPDATE users SET first_name = %(fn)s, last_name = %(ln)s, email = %(em)s WHERE id = %(id)s;"

    data = {
        "id" : id,
        "fn" : request.form['update_first_name'],
        "ln" : request.form['update_last_name'],
        "em" : request.form['update_email']
    }

    update_info = mysql.query_db(query, data)
    print(update_info)

    return redirect(f"/user/{id}")

@app.route("/user/<id>/delete", methods = ['POST'])
def delete_user(id):
    user_id = int(id)

    mysql = connectToMySQL("users_assignment")

    query = "DELETE FROM users WHERE id = %(id)s;"
    

    data = {
        "id" : user_id

    }

    delete_info = mysql.query_db(query, data)


    return redirect("/users")

if __name__ == "__main__":
    app.run(debug=True)
