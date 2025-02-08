let mutable x = 10

let mutable y = 20

let add x y = x + y

let mutable z = add x y

printf "%d\n" z //Prints 30

x <- 100

y <- 200

printf "%d\n" z //Still prints 30.  The value of z is not updated.

//To fix this, either recalculate z or use a function that returns a value

let add2 x y = x + y

let z2 = add2 x y

printf "%d\n" z2 //Prints 300

