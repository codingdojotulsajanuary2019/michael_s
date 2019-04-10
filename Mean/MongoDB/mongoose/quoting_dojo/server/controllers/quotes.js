module.exports = {
    index: function(req, res){
        res.render('index', {errors: ""});
    },
    show_quotes: function(req, res){
        User.find({}, function(err, quotes){
            if(err){
                console.log("something went wrong")
            }
            else{
                console.log('getting quotes')
                res.render('quotes', {quotes: quotes })
                console.log(quotes)
            }
        }).sort({createdAt: -1})
    }
}