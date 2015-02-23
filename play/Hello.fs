[<EntryPoint>]
let main(args) =
  let text = args.[0]
  let number = (int32)args.[1]
  printfn "Hello %s %i" text number
  0
