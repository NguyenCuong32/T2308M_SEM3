function example1() {
    var x = 10;
    if (true) {
        x = 20;
        console.log("In block: "+ x);
    }
    console.log("Out block: " +x);
}
function example2() {
    let y = 10;
    if (true) {
        y = 20;
        console.log("In block "+y);
    }
    console.log("Out block "+y);
}
example1();
example2();