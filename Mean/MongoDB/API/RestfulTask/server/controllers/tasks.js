const mongoose = require('mongoose');
const Task = mongoose.model('Task');

module.exports = {
    redirect: (req, res)=>{
        res.redirect('/tasks')
    },
    index: (req, res)=>{
        Task.find({}, (err, tasks)=>{
            if(err){
                res.json({success: false, error: err});
            } else {
                res.json({success: true, tasks: tasks})
            }
        })
    },
    create: (req, res)=> {
        console.log(req.method);
        console.log(req.params);
        let newTask;
        newTask = req.params;
        const task = new Task(newTask);
        task.save((err)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.redirect('/')
            }
        })
    },
    get_by_id: (req, res)=>{
        console.log(req.method);
        let id = req.params.id;
        Task.find({_id: id},(err,tasks)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.json({success: true, task: tasks})
            }
        })
    },

    update: (req, res)=>{
        console.log(req.method);
        let id = req.params.id;
        console.log(req.body);
        Task.update({_id:id},{title: req.body.title, description: req.body.description, completed: req.body.completed},(err)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.redirect('/');
            }
        })
    },

    delete: (req, res)=>{
        console.log(req.method);
        let id = req.params.id;
        Task.findByIdAndDelete(id, (err)=>{
            if(err){
                res.json({success: false, error: err})
            }
            else{
                res.redirect('/');
            }
        })
    }


}