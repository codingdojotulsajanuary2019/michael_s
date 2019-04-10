// Require the Express Module
var express = require('express');
// Create an Express App
var app = express();

// Require body-parser (to receive post data from clients)
var bodyParser = require('body-parser');
// Integrate body-parser with our App
app.use(bodyParser.urlencoded({ extended: true }));

// Require path
var path = require('path');

// Setting our Static Folder Directory
app.use(express.static(path.join(__dirname, './static')));

// Setting our Views Folder Directory
app.set('views', path.join(__dirname, './views'));

// Setting our View Engine set to EJS
app.set('view engine', 'ejs');


// Routes
// Root Request
// require('./routes')(app);
// session
var session = require('express-session')
app.use(session({
    secret: '2SHEA',
    resave: false,
    saveUninitialized: true,
    cookie: {secure: true}

}))

const flash = require('express-flash');
app.use(flash())


var mongoose = require('mongoose');

//    Mongoose Validatator
var validate = require('mongoose-validator')
var nameValidator = [
    validate({
      validator: 'isLength',
      arguments: [3, 50],
      message: 'Name must be between {ARGS[0]} and {ARGS[1]} characters',
    }),
    validate({
      validator: 'isAlphanumeric',
      passIfEmpty: true,
      message: 'Name should contain alpha-numeric characters only',
    }),
  ]

var quoteVaildator = [
    validate({
        validator: 'isLength',
        arguments: [5],
        message: 'Quote must be longer than {ARGS[0]} characters',
    })
]
// This is how we connect to the mongodb database using mongoose
//   our db in mongodb -- this should match the name of the db you are going to use for your project.
mongoose.connect('mongodb://localhost/quoting_dojo', {useNewUrlParser: true });
var UserSchema = new mongoose.Schema({
    name: {type: String, require: true, validate: nameValidator},
    quote: {type: String, require: true, validate: quoteVaildator}
   }, {timestamps: true})

mongoose.model('User', UserSchema);
    // We are setting this Schema in our Models as 'User'copy
const User = mongoose.model('User') // We are retrieving this Schema from our Models, named 'Us
   // Use native promises (only necessary with mongoose versions <= 4)

require('./server/config/routes.js')(app);



app.post('/quotes/add', function (req, res){
    console.log("POST DATA", req.body);
    var user = new User(req.body);
    user.save(function(err){
        if(err){
            console.log("We Have An Error", err);
            var errorArr = [];
            for(var key in err.errors){
                console.log(key);
                console.log(err.errors[key].message)
                errorArr.push({
                    name : key, 
                    error : err.errors[key].message })
            }
            console.log(errorArr);
            res.render('index', {errors: errorArr });

        }
        else{
            res.redirect('/quotes');
        }
    })

})

// Add User Request 
// app.post('/users', function(req, res) {
//     console.log("POST DATA", req.body);
//     // This is where we would add the user from req.body to the database.
//       // create a new User with the name and age corresponding to those from req.body
//   var user = new User({name: req.body.name, age: req.body.age});
//   // Try to save that new user to the database (this is the method that actually inserts into the db) and run a callback function with an error (if any) from the operation.
//   user.save(function(err) {
//     // if there is an error console.log that something went wrong!
//     if(err) {
//       console.log('something went wrong');
//     } else { // else console.log that we did well and then redirect to the root route
//       console.log('successfully added a user!');
//     }
//     res.redirect('/');
//   })
// })
// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
})

