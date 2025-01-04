let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 which is correct

//However if we use this function:
let swap2 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable x2 = ref 10
let mutable y2 = ref 20
swap2 x2 y2
printf "%d %d" (!x2) (!y2) //This will print 20 10 which is correct

//The problem comes when you want to swap values using tuples:
let swapTuple (x,y) = (y,x)

let a = 10
let b = 20
let (a,b) = swapTuple (a,b) //This doesn't swap the values
printf "%d %d" a b //This will print 10 20 which is incorrect, as expected

//This is because tuples are immutable in F# and swapTuple does not modify the original variables a and b, but instead it creates a new tuple.