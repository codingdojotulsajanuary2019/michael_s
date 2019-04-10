const express = require('express');
const app = express();
const PORT = 8000;
const bodyParser = require('body-parser');

// for future api's, that will allow for json and url encoded form data form post, available in the req.body
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));

require('./server/config/mongoose');
require('./server/config/routes')(app);

app.listen(PORT, ()=>{
    console.log(`Listening on port ${PORT}!`);
})