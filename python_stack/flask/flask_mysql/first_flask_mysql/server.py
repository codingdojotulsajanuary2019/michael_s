from flask import Flask, render_template, redirect, request 
from mysqlconnection import connectToMySQL


app = Flask(__name__)
@app.route("/")
def index():
    # call the function, passing in the name of our db
    mysql = connectToMySQL('first_flask')
    # call the query_db function, pass in the query as a string
    friends = mysql.query_db('SELECT * FROM friends;')


    print(friends)
    return render_template("index.html", all_friends = friends)


@app.route("/create_friend", methods=["POST"])
def add_friend_to_db():
    mysql = connectToMySQL("first_flask")

    query = "INSERT INTO friends (first_name, last_name, occupation, created_at, updated_at) VALUES (%(fn)s, %(ln)s, %(occup)s, NOW(), NOW()); "

    data = {
        "fn": request.form["fname"],
        "ln": request.form["lname"],
        "occup": request.form["occ"]
    }

    new_Friend_id = mysql.query_db(query, data)

    return redirect("/")

 # QUERY: INSERT INTO first_flask (first_name, last_name, occupation, created_at, updated_at)
 #                         VALUES (fname from form, lname from form, occupation from form, NOW(), NOW());

if __name__ == "__main__":
    app.run(debug=True)
