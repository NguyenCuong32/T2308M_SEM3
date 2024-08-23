const express = require('express');
const app = express();

app.get('/',(req,res)=>{
    res.send("Hello world.");
})

let port = 9000;
app.listen(port,()=>{
    console.log(`Server listening on ${port}.`);
})