const User = require('../models/userModel');

exports.getUsers = async(req,res)=>{
    try {
        const users = await User.find();
        console.log(users.toString());
        res.render('users/index',users);
    } catch (err) {
        console.log(err);
    }
}