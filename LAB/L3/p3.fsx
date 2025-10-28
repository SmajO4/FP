// Napraviti pipeline operacija koji uzima pocetnu vrijednost
// nakon toga aplicira serije aritmetickih operacija nad datom
// pocetnom vrijednoscu.



let add x y = (+) y x
let mul x y = (*) y x
let sub x y = (-) y x
let div x y = (/) y x

let start = 11
let result = start |> add 5 |> mul 4 |> sub 3 |> div 2 
            // aplikacija ima najveci prioritet!
printfn "%d" result
