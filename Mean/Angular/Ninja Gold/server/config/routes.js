const Ninja = require('./../controllers/ninjas');

module.exports = (app) => {
    app.post('/ninjaGold', Ninja.create)
    app.get('/ninjaGold', Ninja.show)
    app.put('/:id', Ninja.update)

} 