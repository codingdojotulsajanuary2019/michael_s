// require express
var express = require("express");
// path module -- try to figure out where and why we use this
var app = express();
var path = require("path");
// create the express app
var session = require("express-session");
app.use(session({
    secret: '2SHEA',
    resave: false,
    saveUninitialized: true,
    cookie: {maxAge: 60000}
}))

var bodyParser = require('body-parser');
// use it!
app.use(bodyParser.urlencoded({ extended: true }));
// static content
app.use(express.static(path.join(__dirname, "./static")));
// setting up ejs and our views folder
app.set('views', path.join(__dirname, './static/views'));
app.set('view engine', 'ejs');

// ///////////////////////////////////////////////////////////////////////
// ROUTES//
// root route to render the index.ejs view
app.get('/', function(req, res) {
    if(req.session.count === undefined)
    {
        req.session.count = 1;
        res.locals.count = req.session.count;
    }
    else
    {
        req.session.count ++;
        res.locals.count = req.session.count;
    }

    console.log(req.session);
    res.render("index")
})

app.get('/addtwo', function(req, res){
    req.session.count += 1;

    res.redirect('/')
})

app.get('/clear', function(req, res){
    req.session.destroy();
    res.redirect('/')
})


// post route for adding a user
// app.post('/users', function(req, res) {
//  console.log("POST DATA", req.body);
//  // This is where we would add the user to the database
//  // Then redirect to the root route
//  res.redirect('/');
// })
// tell the express app to listen on port 8000
app.listen(8000, function() {
 console.log("listening on port 8000");
});
