const Tasks = require('./../controllers/tasks');

module.exports = (app) => {
    app.get('/tasks', Tasks.index)
    app.post('/new/:title/:description', Tasks.create)
    app.get('/tasks/find/:id', Tasks.get_by_id)
    app.put('/tasks/update/:id', Tasks.update)
    app.delete('/tasks/delete/:id', Tasks.delete)


}