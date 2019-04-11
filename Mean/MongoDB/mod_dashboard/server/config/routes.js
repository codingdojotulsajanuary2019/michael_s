const Model = require('./../controllers/models');

module.exports = (app) => {
    app.get('/', Model.index)

}