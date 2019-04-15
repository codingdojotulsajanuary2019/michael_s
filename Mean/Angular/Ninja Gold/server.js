const express = require('express');
const app = express();
const PORT = 8000;
const bodyParser = require('body-parser');
const path = require('path');

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));
app.use(express.static(path.join(__dirname, '/public/dist/public')));


require('./server/config/mongoose');
require('./server/config/routes')(app);


app.listen(PORT, ()=>{
    console.log(`Listening on port ${PORT}!`);
})