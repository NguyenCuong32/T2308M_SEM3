const mongoose = require("mongoose");
const express = require("express");
// const app = express();
const app = require('./app');
app.use(express.json());
mongoose
  .connect("mongodb://root:123456@127.0.0.1:27017/SIS?authSource=admin")
  .then(() => {
    console.log("Connection successful.");
  })
  .catch(() => {
    console.log("Unconnection to database");
  });

const port = 9001;

app.listen(port, () => {
  console.log(`Server listening on ${port}`);
});
