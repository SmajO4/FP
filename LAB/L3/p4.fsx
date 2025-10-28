// Napisati izraz koji treba kvadrira broj 5, a nakon
// toga da ga uveca za 1. Rezultat generisati prvo koristeci
// operator aplikacija funkcije, nakon toga forward pipe
// i konacno backward pipe.

let num = 5
let square x = x * x
let inc x = x + 1 

printfn "%d" (inc (square num))
printfn "%d" (num |> square |> inc)
printfn "%d" (inc <| (square <| num))


