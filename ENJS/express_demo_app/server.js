const app = require('./app');
const mongoose = require('mongoose');

mongoose.connect('mongodb://root:123456@127.0.0.1:27017/SIS?authSource=admin')
    .then(()=>{
        console.log("Connection to database successfull");
    })
    .catch(()=>{
        console.log("Connection to database unsuccessfull");
    });

const port = 9000;
app.listen(port,()=>{
    console.log(`Listening on port ${port}`);
})