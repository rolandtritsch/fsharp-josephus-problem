// A bare-bones solution that computes the position of the last surviving position in the Josephus problem
// Solution uses recursion: f(n,k)=((f(n-1,k)+k-1) mod n) + 1 
#light

//The function that does it
let rec josephusLastPosn n k =
     match n with
     | 1 -> 1
     | _ -> ((josephusLastPosn (n-1) k) + k - 1 ) % n + 1

//Input (count step) and print result
open System

Console.Write("Enter Count: ")
let count = Console.ReadLine()

Console.Write("Enter Step: ")
let step = Console.ReadLine()
  
printfn "The surviving position is: %d" (josephusLastPosn (int32(count)) (int32(step))) 

//Wait for the user to press any key
Console.ReadKey(true)