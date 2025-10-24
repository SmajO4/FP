// Napraviti pipeline operacija koji uzima pocetnu vrijednost
// nakon toga aplicira serije aritmetickih operacija nad datom
// pocetnom vrijednoscu.



let add x y = 
  x + y
let sub x y =
  x - y
let mul x y = 
  x * y
let div x y =
  x / y

let poc = 14

let res = poc |> add 2 |> sub 4 |> mul 5 |> div 3 
printfn "%A" res


let foo = add 2 
1 |> foo
