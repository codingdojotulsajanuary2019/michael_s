from flask import Flask, render_template, request, redirect

app = Flask(__name__)

@app.route("/")
def home_form():

    return render_template("survey.html")

@app.route("/result", methods=['POST'])
def show_result():
    print("*"*80)
    print("GOT INFO FROM FORM!")
    print(request.form)
    name_from_form = request.form['name']
    location_from_form = request.form['location']
    fav_language_from_form = request.form['favlang']
    comment_result_from_form = request.form['comment']
    gender_result = request.form['gender_result']
    pizaa_toppings = request.form.getlist('topping')
   

    return render_template(
        "result.html",
         name_result = name_from_form,
         location_result = location_from_form,
         fav_language_result = fav_language_from_form,
         comment_result = comment_result_from_form,
         gender_result = gender_result,
         topping_choices = pizaa_toppings,

          )





if __name__ == "__main__":
    app.run(debug=True)