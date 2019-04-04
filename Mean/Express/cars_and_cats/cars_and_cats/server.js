var express = require("express");

var app = express();

app.get('/', function(request, response){
    response.render('index')
})

app.get('/cars', function(request, response){
    response.render('cars');
})

app.get('/cats', function(request, response){
    response.render('cats');
})

app.use(express.static(__dirname + "/static"));
app.set('views', __dirname + '/static/views');
app.set('view engine', 'ejs');
app.listen(8000, function(){
    console.log("listening on port 8000");
})