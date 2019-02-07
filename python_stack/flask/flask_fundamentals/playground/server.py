from flask import Flask, render_template

app = Flask(__name__)

@app.route("/play")
def playground():

    return render_template("play.html")


@app.route("/play/<times>")
def num_of_boxes(times):

    return render_template("play.html", times = int(times))


@app.route("/play/<times>/<color>")
def num_and_color(times, color):

    return render_template("play.html", times =int(times), color = color)

if __name__ == "__main__":
    app.run(debug=True)