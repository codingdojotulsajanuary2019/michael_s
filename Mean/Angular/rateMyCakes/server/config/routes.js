const Cake = require('./../controllers/cakes');

module.exports = (app) => {
    app.post('/new', Cake.create)
    app.get('/all/cakes', Cake.allCakes)
    app.put('/update', Cake.rateCake)

}