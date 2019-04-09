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

// //    Mongoose Validatator
// var validate = require('mongoose-validator')
// var nameValidator = [
//     validate({
//       validator: 'isLength',
//       arguments: [3, 50],
//       message: 'First Name must be between {ARGS[0]} and {ARGS[1]} characters',
//     }),
//     validate({
//       validator: 'isAlpha',
//       passIfEmpty: true,
//       message: 'Last Name should contain characters only',
//     }),
//   ]

// var owlVaildator = [
//     validate({
//         validator: 'isLength',
//         arguments: [3],
//         message: 'Type must be longer than {ARGS[0]} characters',
//     })
// ]
// This is how we connect to the mongodb database using mongoose
//   our db in mongodb -- this should match the name of the db you are going to use for your project.
mongoose.connect('mongodb://localhost/message_board', {useNewUrlParser: true });

// var UserSchema = new mongoose.Schema({
//     name: {type: String, required: [true, "Name cannot be blank!"]}
//    }, {timestamps: true})
//    mongoose.model('User', UserSchema); // We are setting this Schema in our Models as 'User'copy
//    var User = mongoose.model('User') // We are retrieving this Schema from our Models, named 'Us
//    // Use native promises (only necessary with mongoose versions <= 4)

var CommentSchema = new mongoose.Schema({
    comment: {type: String, required: [true, "Comment cannot be blank"], minlength: [2, "Message must be 2 character or longer"]},
    commenter: {type: String, required: [true, "Name Cannot be blank"]},
    },{timestamps: true})
    mongoose.model('Comment', CommentSchema);
    var Comment = mongoose.model('Comment')

var MessageSchema = new mongoose.Schema({
    message: {type: String, required: [true, "Message cannot be blank"], minlength: [5, "Message must be 5 character or longer"]},
    creator: {type: String, required: [true, "Name Cannot be blank"]},
    comments: [CommentSchema]
    },{timestamps: true})
    mongoose.model('Message', MessageSchema);
    var Message = mongoose.model('Message')





app.get('/', function(req, res){
    Message.find({}, function(err, messages){
        if(err){
            console.log("ERROR", err)
        }
        else{
            res.render('index', {Allmessages: messages})

        }
    });
})

app.post('/post', function(req, res){
    console.log(req.body);
    var message = new Message(req.body);
    message.save(function(err){
        if(err){
            console.log("ERROR", err);
            res.redirect('/')       
        }
        else{
            res.redirect('/')
        }
    })
})
app.post('/comment/:id', function(req, res){
    console.log(req.body);

    Comment.create(req.body, function(err, data){
        if(err){
            console.log("ERROR", err)
            res.redirect('/')
        }
        else{
            Message.findOneAndUpdate({_id: req.params.id}, {$push: {comments: data}}, function(err, data){
                if(err)
                {
                    console.log("ERROR", err);
                }
                else{
                    console.log("GREAT SUCCESS!!")
                    res.redirect('/')
                }
            })
        }
    })
})


// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
})

