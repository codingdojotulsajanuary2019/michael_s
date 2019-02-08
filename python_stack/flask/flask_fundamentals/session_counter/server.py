from flask import Flask, render_template, request, redirect, session

app = Flask(__name__)
app.secret_key = 'my secret key'

@app.route("/", methods=['POST'])
def session_count():
    session['session_count']
    return render_template("counter.html")


if __name__ == "__main__":
    app.run(debug=True)