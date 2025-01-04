let swap x y = 
    let temp = x
    x <- y
    y <- temp

let swapRef (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

// Correct way to swap values using tuples, recognizing their immutability
let swapTuple (x,y) = (y,x)

//Demonstrates that this is correct by using the return value of swapTuple
let a = 10
let b = 20
let (a',b') = swapTuple (a,b) 
printf "%d %d" a' b' //This will print 20 10 which is correct

//The original variables a and b are unchanged:
printf "%d %d" a b //This will print 10 20 which is correct