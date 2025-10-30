let n: int = System.Console.ReadLine() |> int
let random: System.Random = System.Random()

// VAS KOD OVDJE
let getRandom (x: int) : (unit -> int) =
    let foo ((): unit) : int = random.Next 10 
    foo
// VAS KOD OVDJE

let k: int = n |> getRandom <| ()
printfn $"Random vrijednost od 0 do {n}: {k}"
