const mongoose = require('mongoose');


// CREATE YOUR MODEL HERE! THIS IS JUST AN EXAMPLE!
const CakeSchema = new mongoose.Schema({
    baker: {type: String, required: [true, 'Name is required!'], minlength: [2, 'Name must be 2 characters long!']},
    image: {type: String, default: ""},
    rating: [{stars:Number, comment: String}]
}, {timestamps: true});

mongoose.model('Cake', CakeSchema);