const mongoose = require('mongoose');
const Cake = mongoose.model('Cake');

module.exports = {

    create: (req, res)=> {
        console.log(req.method);
        console.log(req.body);
        let newCake = req.body;
        const cake = new Cake(newCake);
        cake.save((err)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.json({success: true})
            }
        })
    },

    allCakes:(req, res)=>{
        Cake.find({}, (err, cakes)=>{
            if(err){
                res.json({success: false, error: err});
            } else {
                res.json({success: true, cakes: cakes})
            }
        })
    },

    rateCake:(req, res)=>{
        console.log('UPDATE REQUEST',req.body);
        Cake.update({_id:req.body._id},{stars: req.body.stars, comment: req.body.comment},(err)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.json({success: true});
            }
        })
    }

}