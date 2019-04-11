const mongoose = require('mongoose');

const ModelSchema = new mongoose.Schema({
    title: {type: String, required: [true, 'Name is required!'], minlength: [2, 'Name must be 2 characters long!']},
    description: {type: String, default: ""},
    completed: {type: Boolean, default: false}
}, {timestamps: true});

mongoose.model('Model', ModelSchema);