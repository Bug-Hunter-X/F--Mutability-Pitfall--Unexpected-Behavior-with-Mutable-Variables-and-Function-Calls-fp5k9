let mutable x = 10

let mutable y = 20

//Instead of using a mutable z, recalculate whenever x or y change
let add x y = x + y

let z = add x y

printf "%d\n" z //Prints 30

x <- 100

y <- 200

let z2 = add x y //Recalculate z

printf "%d\n" z2 //Prints 300

//Alternatively, make the addition function return the value:

let add2 x y = x + y

let z3 = add2 x y

printf "%d\n" z3 //Prints 300
x <- 1000
y <- 2000
let z4 = add2 x y
printf "%d\n" z4 //Prints 3000
