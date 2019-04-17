from flask import Flask, render_template, request, redirect
app = Flask(__name__)  

@app.route('/')         
def index():
    return render_template("index.html")

@app.route('/checkout', methods=['POST'])         
def checkout():
    print(request.form)
    strawberry_count = request.form['strawberry']
    raspberry_count = request.form['raspberry']
    apple_count = request.form['apple']
    first_name_from_form = request.form['first_name']
    last_name_from_form = request.form['last_name']
    student_id_from_form = request.form['student_id']
    print("*"*80)
    print(f"Charging {first_name_from_form} {last_name_from_form} for {int(strawberry_count)+int(raspberry_count)+int(apple_count)} fruits ")
    print("*"*80)

    return render_template(
        "checkout.html",
        amount_of_strawberries = int(strawberry_count),
        amount_of_raspberries = int(raspberry_count),
        amount_of_apples = int(apple_count),
        first_name = first_name_from_form,
        last_name = last_name_from_form,
        student_id = student_id_from_form,
        
        )

@app.route('/fruits')         
def fruits():
    return render_template("fruits.html")

if __name__=="__main__":   
    app.run(debug=True)    
