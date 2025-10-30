// Napraviti pipeline operacija koji uzima pocetnu vrijednost
// nakon toga aplicira serije aritmetickih operacija nad datom
// pocetnom vrijednoscu.



let add x y = (+) x y 
let mul x y = (*) x y
let sub x y = (-) x y
let div x y = (/) x y

let start = 11
let result = start |> add 5 |> mul 4 |> sub 3 |> div 2 
            // aplikacija ima najveci prioritet!
printfn "%d" result
