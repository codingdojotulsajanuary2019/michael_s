const mongoose = require('mongoose');
const Ninja = mongoose.model('Ninja');

module.exports = {

    show: (req, res)=>{ex
        Ninja.findOne({})
    },

    create: (req, res)=>{
        Ninja.create(req.body, (err, game) => {
            if(err){
                res.json({status: false, error: err});
            }
            else{
                res.json({status: true, game: game})
            }
        })
    },

    update: (req, res)=>{
        console.log(req.body);
        Ninja.findOne({_id: req.params.id},(err, game)=>{
            if(err){
                res.json({status: false, error: err})
            }
            else{
                console.log("Update Succesfull");
                game.score += req.body.score
                game.save( err => {
                    if(err){
                        res.json({status: false, error: err});
                    }
                    else{
                        res.json({status: true, game: game})
                    }
                });
            }
        })
    }

}