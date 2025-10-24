(*
========================================
 F# PROVJERA – Novi zadaci (1–10)
========================================
*)

(*
*)
printfn "== Zadatak 1: 8 * 2^k = 1 <<< (k + 3) =="

let k1: int = 6
let lhs1: int = 8 * (1 <<< k1)
let rhs1: int = 1 <<< (k1 + 3)
let ok1: bool = lhs1 = rhs1
printfn "k=%d -> %b" k1 ok1
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 2: (p / 2^k) = (p >>> k) za p>=0 =="

let p2: int = 1025
let k2: int = 3
let lhs2: int = p2 / (1 <<< k2)
let rhs2: int = p2 >>> k2
let ok2: bool = (p2 >= 0) && (k2 >= 0) && (lhs2 = rhs2)
printfn "p=%d, k=%d -> %b" p2 k2 ok2
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 3: List.map i parcijalna aplikacija =="

let add (a: int) (b: int) : int = a + b
let add7: int -> int = add 7
let base3: int list = [ 0; 1; 2; 3 ]
let res3: int list = base3 |> List.map add7
printfn "Rezultat: %A" res3
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 4: let i fun (ekvivalentne funkcije) =="

let sqrL (x: int) : int = x * x
let sqrF: int -> int = fun (x: int) -> x * x
let same4: bool = sqrL 9 = sqrF 9
printfn "Jesu li isti rezultati? %b" same4
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 5: Ispis i evaluacija =="

let foo5 (x: int) (y: int) : int =
    printf "A"
    x - y

printf "B"
let bar5: int -> int = foo5 10
printf "C"
let tar5: int = bar5 4
printf "D"
let _: int = tar5
printfn "  (tipovi: foo5:int->int->int, bar5:int->int, tar5:int)"
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 6: readAndInc : unit -> unit =="

let readAndInc (_: unit) : unit =
    printf "Unesi broj: "
    let n: int = System.Console.ReadLine() |> int
    printfn "Povecano: %d" (n + 1)

// Ako pokrećeš interaktivno, otkomentiraj:
// readAndInc ()
printfn "(funkcija spremna, ali unos preskočen)"
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 7: makePow (funkcija vraća funkciju) =="

let makePow (k: int) : (int -> int) =
    fun (n: int) ->
        let mutable acc: int = 1

        for _i in 1..k do
            acc <- acc * n

        acc

let pow3: int -> int = makePow 3
let ex7: int = pow3 2
printfn "2^3 = %d" ex7
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 8: Pattern match + iznimka (nonZero) =="

let nonZero (x: int) : bool =
    match x with
    | 0 -> failwith "nula"
    | _ -> true

// ispravan poziv:
let _: bool = nonZero 5
printfn "(nonZero 5 -> true; ako probaš 0, baca iznimku)"
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 9: between + isNotTeen =="

let between (lo: int) (hi: int) (x: int) : bool = lo <= x && x <= hi
let isTeen: int -> bool = between 13 19
let isNotTeen: int -> bool = fun x -> not (isTeen x)

let ages9: int list = [ 10; 13; 17; 20 ]
let notTeens: int list = ages9 |> List.filter isNotTeen
printfn "Nisu tinejdžeri: %A" notTeens
printfn ""


// -------------------------------------

(*
*)
printfn "== Zadatak 10: safeDiv (try/with) =="

let safeDiv (x: int) (y: int) : int =
    try
        x / y
    with :? System.DivideByZeroException ->
        0

let d1: int = safeDiv 10 0
let d2: int = safeDiv 10 3
printfn "safeDiv 10 0 = %d, safeDiv 10 3 = %d" d1 d2
printfn ""
printfn "== KRAJ =="
