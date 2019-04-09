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
      message: 'First Name must be between {ARGS[0]} and {ARGS[1]} characters',
    }),
    validate({
      validator: 'isAlpha',
      passIfEmpty: true,
      message: 'Last Name should contain characters only',
    }),
  ]

var owlVaildator = [
    validate({
        validator: 'isLength',
        arguments: [3],
        message: 'Type must be longer than {ARGS[0]} characters',
    })
]
// This is how we connect to the mongodb database using mongoose
//   our db in mongodb -- this should match the name of the db you are going to use for your project.
mongoose.connect('mongodb://localhost/owl_dashboard', {useNewUrlParser: true });
var OwlSchema = new mongoose.Schema({
    first_Name: {type: String, require: true, validate: nameValidator},
    last_Name: {type: String, require: true, validate: nameValidator},
    type: {type: String, require: true, validate: owlVaildator}
   }, {timestamps: true})
   mongoose.model('Owl', OwlSchema); // We are setting this Schema in our Models as 'User'copy
   var Owl = mongoose.model('Owl') // We are retrieving this Schema from our Models, named 'Us
   // Use native promises (only necessary with mongoose versions <= 4)


app.get('/', function(req, res){
    Owl.find({}, function(err, owls){
        if(err){
            console.log("ERROR", err);
        }
        else{
            res.render('index');
        }
    });
})


// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
})

