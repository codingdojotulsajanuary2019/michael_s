const mongoose = require('mongoose');
const Model = mongoose.model('Model');

module.exports = {

    index: (req, res)=>{
        res.render('index')
    }

}