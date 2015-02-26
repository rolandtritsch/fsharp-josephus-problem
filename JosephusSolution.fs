// A bare-bones solution that computes the position of the last surviving
// position in the Josephus problem. One method uses recursion:
//
// f(n,k)=((f(n-1,k)+k-1) mod n) + 1
//
// The other method uses tail recursion to cater for large inputs
#light

//Recursive function
let rec josephusR n k =
     match n with
     | 1 -> 1
     | _ -> ((josephusR (n-1) k) + k - 1 ) % n + 1

//Tail-recursive
let josephusTR n k =
    let rec josephusTrailRec n k i acc =
        if (i > n) then
           acc + 1
        else
            josephusTrailRec n k (i + 1) ((acc + k) % i)
    josephusTrailRec n k 1 0

[<EntryPoint>]
let main(args) =
  let count = (int32)args.[0]
  let step = (int32)args.[1]

  printfn "The surviving position is: %i" (josephusR count step)
  printfn "The surviving position is: %i" (josephusTR count step)
  0
