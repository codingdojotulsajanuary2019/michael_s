from flask import Flask

app = Flask(__name__)

@app.route("/")
def hello_world():

    return "Hello World!"

@app.route("/dojo")
def dojo():

    return "Dojo!"

@app.route("/say/<name>")
def say_hi(name):

    return f"Hi {name}"

@app.route("/repeat/<num>/<word>")
def repeat(num:int, word:str):
    repeating = f"{word} \n"  * int(num) 

    return repeating


@app.route('/', defaults={'path': ''})
@app.route('/<path:path>')
def catch_all(path):
    return "Sorry! No response. Try again." 



if __name__ == "__main__":   # Ensure this file is being run directly and not from a different module. SHOULD BE LAST STATMENT IN APP!
    app.run(debug=True)    # Run the app in debug mode.
