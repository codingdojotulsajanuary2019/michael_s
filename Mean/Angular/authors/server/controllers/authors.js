const mongoose = require('mongoose');
const Author = mongoose.model('Author');

module.exports = {

    getAll: (req, res)=>{
        Author.find({}, (err, authors)=>{
            if(err){
                res.json({success: false, error: err});
            } else {
                res.json({success: true, authors: authors})
            }
        })
    },
    create: (req, res)=> {
        console.log(req.body);
        console.log("BODY FROM CONTROLLER", req.body);
        let newAuthor = req.body
        const author = new Author(newAuthor);
        author.save((err)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.json({success: true})
            }
        })
    },
    get_by_id: (req, res)=>{
        console.log(req.method);
        let id = req.params.id;
        Author.find({_id: id},(err,author)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.json({success: true, author: author})
            }
        })
    },

    update: (req, res)=>{
        console.log(req.method);
        let id = req.params.id;
        let options = {runValidators : true }
        console.log(req.body);
        Author.update({_id:id},{name: req.body.name}, options, (err, author)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.json({success: true, author: author});
            }
        })
    },

    delete: (req, res)=>{
        console.log(req.method);
        console.log("MADE IT TO SERVER", req.params)
        let id = req.params.id;
        Author.findByIdAndDelete(id, (err)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.json({success: true});
            }
        })
    }

}