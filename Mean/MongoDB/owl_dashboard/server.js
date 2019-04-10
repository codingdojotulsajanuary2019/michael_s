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
            res.render('index', {errors: "", owls: owls});
        }
    });
})

app.get('/owls/new', function(req, res){

    res.render('NewOwl', {errors: ""});
})

app.post('/owls', function (req, res){
    console.log("POST DATA", req.body);
    var owl = new Owl(req.body);
    owl.save(function(err){
        if(err){
            console.log("We Have An Error", err);
            var errorArr = [];
            for(var key in err.errors){
                console.log(key);
                console.log(err.errors[key].message)
                errorArr.push({
                    field : key, 
                    error : err.errors[key].message })
            }
            console.log(errorArr);
            res.render('NewOwl', {errors: errorArr });

        }
        else{
            res.redirect('/');
        }
    })

})

app.get('/owls/:id', function(req, res){
    var id = req.params.id;
    Owl.find({_id: id}, function(err, owl){
        if(err){
            console.log("ERROR", err);
        }
        else{

            res.render('ViewOwl', {owl: owl})
            console.log(owl);
        }
    })
})
app.post('/owls/:id', function(req, res){
    var id = req.params.id;
    console.log(req.body);
    Owl.findByIdAndUpdate(id,{
             $set: {
                first_Name: req.body.first_Name,
                last_Name: req.body.last_Name,
                type: req.body.type
            }},nameValidator,
                function(err){
                if(err){
                    console.log("ERROR", err);
                    res.redirect(`/owls/${id}`)
                }
                else{
                    res.redirect('/');
                    console.log("Succesfully Changed!")

                }
    })
})

app.get('/owls/destroy/:id', function(req, res){
    var id = req.params.id;
    console.log(id);
    Owl.remove({_id: id}, function(err){
        if(err){
            console.log("ERROR", err);
        }
        else{
            res.redirect("/");
        }
    })
})

app.get('/owls/edit/:id', function(req, res){
    var id = req.params.id;
    Owl.find({_id: id}, function(err, owl){
        if(err){
            console.log("We Have An Error", err);
            var errorArr = [];
            for(var key in err.errors){
                console.log(key);
                console.log(err.errors[key].message)
                errorArr.push({
                    field : key, 
                    error : err.errors[key].message })
            }
            console.log(errorArr);
            res.render('EditOwl', {errors: errorArr, owl:owl });
        }
        else{
            res.render('EditOwl', {errors:"", owl: owl})
        }
    })
})

// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
})

