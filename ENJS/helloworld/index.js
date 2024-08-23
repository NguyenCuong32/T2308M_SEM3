const readline = require('node:readline');
console.log('hello world');

var eat = function(){
    console.log('I am eating');
}

var walk = function(){
    console.log('I am walking');
}

var run = function(){
    console.log('I am runing');
}

var total = function(x,y){
    var sum = x+y;
    console.log(sum);
}

var menu = function(){
    while (true) {
        let mode ;
        const rl = readline.createInterface({
            input: process.stdin,
            output: process.stdout,
          });
          
          rl.question(`What's your name?`, mode => {
            rl.close();
          });
        if(mode==1){
            eat();
        }
        if(mode==2){
            walk();
        }
        if(mode==3){
            run();
        }
        if (mode==4) {
            total();
        }
    }
}


// eat();
// walk();
// run();

// total(3,6);

// menu();




