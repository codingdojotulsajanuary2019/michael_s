const express = require('express');
const app = express();
const PORT = 5000;
const bodyParser = require('body-parser');
const path = require('path');
// const session = require('express-session')
const flash = require('express-flash');

// for future api's, that will allow for json and url encoded form data form post, available in the req.body
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));
app.use(express.static(path.join(__dirname, '/public/dist/public')));
// app.use(flash())
// app.set('views', path.join(__dirname, './client/views'));
// app.set('view engine', 'ejs');
// app.use(session({
//     secret: '2SHEA',
//     resave: false,
//     saveUninitialized: true,
//     cookie: {secure: true}

// }))

require('./server/config/mongoose');
require('./server/config/routes')(app);


app.listen(PORT, ()=>{
    console.log(`Listening on port ${PORT}!`);
})