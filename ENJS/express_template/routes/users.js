var express = require('express');
var userController = require('../controllers/userController');
var router = express.Router();


router.route('/')
      .get(userController.getUsers)
      .post(userController.createUser)

module.exports = router;
