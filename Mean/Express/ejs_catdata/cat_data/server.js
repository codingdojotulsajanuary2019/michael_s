var express = require("express");

var app = express();

app.get('/', function(request, response){
    response.render('index')
;})

app.get('/sadcat', function(request, response){
    var sadcat = {
        name : "Sad Cat",
        mood: "Sad",
        activities: ["Cry", "Whine", "Sad Meows"],
        food: "Too Sad To Eat" 
    };

    response.render('sadcat', {sadcat: sadcat});
})

app.get('/grumpycat', function(request, response){
    var grumpycat = {
        name : "Grumpy Cat",
        mood: "Pissed",
        activities: ["Pout", "Be Mad", "Wish it was a dog"], 
        food: "Pizza" 
    };

    response.render('grumpycat', {grumpycat: grumpycat});
})

app.get('/sillycat', function(request, response){
    var sillycat = {
        name : "Silly Cat", 
        mood: "Goofy", 
        activities: ["Chase Mice", "Chase Own Tail", "Knock Things Over"], 
        food: "Fish" 
    };

    response.render('sillycat', {sillycat: sillycat});
})



app.use(express.static(__dirname + '/static'));
app.set('views', __dirname + '/static/views');
app.set('view engine', 'ejs');
app.listen(8000, function(){
    console.log("listening on port 8000");
})