from flask import Flask  # Import Flask to allow us to create our app
# Create a new instance of the Flask class called "app"
app = Flask(__name__)
# The "@" decorator associates this route with the function immediately following
@app.route('/')
def hello_world():
    return 'Hello World!'  # Return the string 'Hello World!' as a response


@app.route("/success")
def success():
    return "SUCCESS!!"

@app.route("/hello/<name>") # for a route "/hello/_____" anything after "/hello/" gets passed as a variable "name"
def hello(name):
    print(name)
    return "Hello, " + name


# for a route '/users/____/____', two parameters in the url get passed as username and id
@app.route("/users/<username>/<id>")
def show_user_profile(username, id):
    print(username)
    print(id)
    return "username: " + username + ", id: " + id

if __name__ == "__main__":   # Ensure this file is being run directly and not from a different module. SHOULD BE LAST STATMENT IN APP! 
    app.run(debug=True)    # Run the app in debug mode.
