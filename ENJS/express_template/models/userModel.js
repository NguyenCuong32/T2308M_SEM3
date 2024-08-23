const mongoose = require("mongoose");
// Định nghĩa dọcument
const userSchema = new mongoose.Schema({
    username: {
      type: String,
      required: [true, "user is required."],
    },
    fullname: {
      type: String,
    },
    address: {
      type: String,
    },
    age: {
      type: Number,
    },
  });
  // Tạo ra model
  const User = mongoose.model("User", userSchema);

module.exports = User;