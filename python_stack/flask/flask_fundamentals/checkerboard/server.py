from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
def home():

    return render_template("checkerboard.html")

@app.route("/<num_rows>")
def make_rows(num_rows):

    return render_template("checkerboard.html", rows = int(num_rows))

@app.route("/<num_rows>/<num_cols>")
def make_rows_and_cols(num_rows, num_cols):

    return render_template("checkerboard.html", rows = int(num_rows), cols = int(num_cols))


@app.route("/<num_rows>/<num_cols>/<color1>/<color2>")
def customize_board(num_rows, num_cols, color1, color2):

    return render_template("checkerboard.html", rows = int(num_rows), cols = int(num_cols), color1 = color1, color2 = color2 )





if __name__ == "__main__":
    app.run(debug=True)