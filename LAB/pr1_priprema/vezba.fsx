let fib_tr x = 
  let rec loop a1 a2 n =
    match n with
    | 0 -> a1
    | 1 -> a2
    | _ -> loop a2 (a1 + a2) (n - 1)
  loop 0 1 x

printfn "%d" (fib_tr 0)
printfn "%d" (fib_tr 1)
printfn "%d" (fib_tr 2)
printfn "%d" (fib_tr 3)
printfn "%d" (fib_tr 4)
printfn "%d" (fib_tr 5)
printfn "%d" (fib_tr 6)
printfn "%d" (fib_tr 7)
