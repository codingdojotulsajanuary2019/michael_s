from flask import Flask, render_template, redirect, request
from petssqlconnect import connectToMySQL


app = Flask(__name__)

@app.route("/")
def pet_index():

    mysql = connectToMySQL('pets')

    pets = mysql.query_db('SELECT * from pets;')
    print(pets)

    return render_template("petsindex.html", all_pets = pets)

@app.route("/add", methods=['POST'])
def add_pet_to_db():

    mysql = connectToMySQL("pets")

    query = "INSERT INTO pets (name, type, created_at, updated_at) VALUES (%(name)s, %(type)s, NOW(), NOW() );"

    data = {
        "name" : request.form['pet_name'],
        "type" : request.form['pet_type']
    }

    new_pet = mysql.query_db(query, data)

    return redirect("/")

if __name__ == "__main__":
    app.run(debug=True)