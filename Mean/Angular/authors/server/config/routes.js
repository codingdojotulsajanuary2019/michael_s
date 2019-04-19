const Author = require('../controllers/authors');

module.exports = (app) => {
    app.get('/api/authors', Author.getAll);
    app.post('/api/new',  Author.create)
    app.delete('/api/delete/:id', Author.delete)
    app.get('/api/authors/:id', Author.get_by_id)
    app.put('/authors/update/:id', Author.update)

}