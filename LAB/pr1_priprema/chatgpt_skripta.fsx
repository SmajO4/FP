(*
========================================
 F# provjera – paket zadataka (1–10)
 Sve je samostalno izvršivo u .fsx
========================================
*)

printfn "== Zadatak 1: 4 * 2^k = 4 <<< k =="

let k1 : int = 7
let lhs1 : int = 4 * (1 <<< k1)   // 4 * 2^k
let rhs1 : int = 4 <<< k1          // lijevi shift
let ok1  : bool = lhs1 = rhs1
printfn "k=%d -> %b" k1 ok1
printfn ""


// -------------------------------------

printfn "== Zadatak 2: (p / 2^k) = (p >>> k) za p>=0 =="

let p2 : int = 1234
let k2 : int = 5

let lhs2 : int = p2 / (1 <<< k2)
let rhs2 : int = p2 >>> k2
let ok2  : bool = (p2 >= 0) && (k2 >= 0) && (lhs2 = rhs2)
printfn "p=%d, k=%d -> %b" p2 k2 ok2
printfn ""


// -------------------------------------

printfn "== Zadatak 3: Random u [a, b) =="

let a3   : int = 10
let b3   : int = 20
let rng3 : System.Random = System.Random()

// Napomena: zahtijeva a3 < b3 u runtime-u
let x3 : int = rng3.Next(a3, b3)
printfn "Rand u [%d, %d): %d" a3 b3 x3
printfn ""


// -------------------------------------

printfn "== Zadatak 4: Ispis i parcijalna aplikacija =="

let foo4 (x:int) (y:int) : int =
    printf "X"
    x * y

printf "Y"
let bar4 : int -> int = foo4 3
printf "Z"
let tar4 : int = bar4 4
printf "W"
let _ : int = tar4
printfn "  (tipovi: foo4:int->int->int, bar4:int->int, tar4:int)"
printfn ""


// -------------------------------------

printfn "== Zadatak 5: Paritet + iznimka (pattern matching) =="

let isEvenOrThrow (x:int) : bool =
    match x % 2 with
    | 0 ->
        printfn "broj je paran"
        true
    | _ ->
        failwith "broj nije paran"

// Poziv koji ne baca:
let _ : bool = isEvenOrThrow 8
// Ako želiš vidjeti iznimku, otkomentiraj sljedeći red:
// let _ = isEvenOrThrow 7
printfn ""


// -------------------------------------

printfn "== Zadatak 6: safeSqrt s validacijom =="

let safeSqrt (x:float) : float =
    if x < 0.0 then failwith "Negativan broj!"
    else sqrt x

let s6a : float = safeSqrt 9.0
printfn "sqrt(9.0) = %f" s6a
// Za iznimku: otkomentiraj
// let _ = safeSqrt (-1.0)
printfn ""


// -------------------------------------

printfn "== Zadatak 7: makeAdder (funkcija vraća funkciju) =="

let makeAdder (a:int) : (int -> int) =
    fun (b:int) -> a + b

let add10 : int -> int = makeAdder 10
let ex7   : int = add10 5
printfn "add10 5 = %d" ex7
printfn ""


// -------------------------------------

printfn "== Zadatak 8: Ispis i evaluacija (2314 očekivano) =="

let foo8 (a:int) (b:int) : (int -> int) =
    printf "1"
    let res (c:int) : int = a + b + c
    res

printf "2"
let f8 : int -> int = foo8 4 5
printf "3"
let g8 : int = f8 6
printf "4"
let _ : int = g8
printfn "  (tipovi: foo8:int->int->(int->int), f8:int->int, g8:int=%d)" g8
printfn ""


// -------------------------------------

printfn "== Zadatak 9: readAndDouble : unit -> unit =="

let readAndDouble (_u:unit) : unit =
    printf "Unesi broj: "
    let n : int = System.Console.ReadLine() |> int
    printfn "Duplo: %d" (2 * n)

// Za automatsko izvršavanje, otkomentiraj:
// readAndDouble ()
printfn "(readAndDouble spreman; preskočen automatski unos u ovoj skripti)"
printfn ""


// -------------------------------------

printfn "== Zadatak 10: between + isTeenager + filter =="

let between (lo:int) (hi:int) (x:int) : bool =
    lo <= x && x <= hi

let isTeenager : int -> bool = between 13 19

let ages10 : int list = [ 5; 12; 14; 19; 21 ]
let teens10 : int list = ages10 |> List.filter isTeenager
printfn "tinejdžeri iz %A -> %A" ages10 teens10
printfn "== Kraj =="

