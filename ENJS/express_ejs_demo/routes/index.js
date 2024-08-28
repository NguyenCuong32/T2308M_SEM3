var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
  var user = {
    name:"Nguyen Van A",
    email:"anv@gmail.com",
    address:"Ha noi"
  }
  res.render('index',user);
});

module.exports = router;