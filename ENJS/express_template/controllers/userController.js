const User = require("../models/userModel");


exports.createUser = async (req, res) => {
  // console.log(req.body);
  try {
    const newUser = User.create(req.body);
    res.status(200).json({
      status: "Success",
      data: {
        user: newUser,
      },
    });
  } catch (err) {
    res.status(500).json({
      status: "Unsuccess",
      data: {
        message: err,
      },
    });
  }
};


exports.getUsers = async(req,res) =>{
    console.log("Get users");
    try {
       var users = User.find();
       res.render('index',users)
           
    } catch (err) {
        res.status(500)
            .json({
                message:"Unsuccess",
                data:err
            });
    }
}



