const mongoose = require('mongoose');


// CREATE YOUR MODEL HERE! THIS IS JUST AN EXAMPLE!
const AuthorSchema = new mongoose.Schema({
    name: {type: String, required: [true, 'Name is required!'], minlength: [3, 'Name must be 3 characters long!']}
}, {timestamps: true});

mongoose.model('Author', AuthorSchema);