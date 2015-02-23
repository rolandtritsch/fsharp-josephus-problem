// A bare-bones solution that computes the position of the last surviving
// position in the Josephus problem. Solution uses recursion:
// f(n,k)=((f(n-1,k)+k-1) mod n) + 1
#light

//The function that does it
let rec josephusLastPosn n k =
     match n with
     | 1 -> 1
     | _ -> ((josephusLastPosn (n-1) k) + k - 1 ) % n + 1


[<EntryPoint>]
let main(args) =
  let count = (int32)args.[0]
  let step = (int32)args.[1]

  printfn "The surviving position is: %i" (josephusLastPosn count step)
  0
