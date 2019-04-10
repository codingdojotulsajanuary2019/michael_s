const mongoose = require('mongoose');
const controller = require('../controllers/quotes')
// const User = mongoose.model.apply('User');

module.exports = function(app) {
    app.get('/', controller.index),
    app.get('/quotes', controller.show_quotes),
    app.post('/quotes/add')
}