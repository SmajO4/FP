#if ZADATAK
(*
Napisati niz let izraza koji dokazuju da vrijedi:

          4 × 2 ^ k=4 << k

Program treba vratiti vrijednost tipa bool.
*)


// VAS KOD:
let k : int = 7

let lhs : int = 4 * (1 <<< k)   // 4 * 2^k
let rhs : int = 4 <<< k          // pomjeraj 4 ulijevo za k

let ok : bool = lhs = rhs
printfn "%b" ok
  
#endif


// ============================================


#if ZADATAK
(*
Dokazati da vrijedi:

       (p / 2 ^ k) = (p >> k)

Uraditi ovo korištenjem samo tipa int.
Program treba vratiti bool.
*)

// VAS KOD:
let p : int = 1234
let k : int = 5

let lhs : int = p / (1 <<< k)    // p / 2^k
let rhs : int = p >>> k           // aritmetički desni shift

let holds : bool = (p >= 0) && (k >= 0) && lhs = rhs
printfn "%b" holds

#endif

// ============================================

#if ZADATAK
(*
Dopuniti kod tako da se ispravno kompajlira i ispisuje slučajni broj u opsegu [a, b).

Potrebno je anotirati sve simbole i ispisati rezultat.
*)

  let a : int = 10
  let b : int = 20
  let rng : System.Random = System.Random()

// Vaš kod ovdje

  let x : int = rng.Next(a, b)   // [a, b)
  printfn "Rand u [%d, %d): %d" a b x


#endif

// ============================================


#if ZADATAK
(*
  Analizirati i objasniti ispis te tipove svih simbola:
  Odgovoriti:

    Da li se kod kompajlira?

    Koji je red ispisa?

    Koji su tipovi foo, bar, tar?
*)

    let foo x y =
        printf "X"
        x * y

    printf "Y"
    let bar = foo 3
    printf "Z"
    let tar = bar 4
    printf "W"
    tar


(*
    kompajlira se.

    tipovi:
    foo : int -> int -> int
    bar : int -> int
    tar : int = 12

    redoslijed ispisa: Y, zatim Z, zatim kod bar 4 se kompletira poziv foo → ispiše X, potom W ⇒ ukupno "YZXW".
*)
#endif

// ============================================

#if ZADATAK
(*
Definisati funkciju koja provjerava da li je broj paran pomoću pattern matcha.
Ako je broj paran, ispisati "broj je paran".
Ako nije, baciti iznimku.
*)
#endif

let isEvenOrThrow (x : int) : bool =
    match x % 2 with
    | 0 ->
        printfn "broj je paran"
        true
    | _ ->
        failwith "broj nije paran"

#endif

// ============================================


#if ZADATAK
(*
Definisati funkciju safeSqrt koja prima realan broj x.
Ako je x < 0.0, treba baciti iznimku "Negativan broj!".

Inače vratiti sqrt x.
Sve anotirati tipovima.
*)

let safeSqrt (x : float) : float =
    if x < 0.0 then failwith "Negativan broj!"
    else sqrt x

// ============================================



#if ZADATAK
(*
Napisati funkciju makeAdder koja prima a : int
i vraća funkciju koja prima b : int i vraća a + b.
Testirati funkciju tako što definišete add10 = makeAdder 10
i izračunate add10 5.
*)
#endif

let makeAdder (a:int) : int -> int = 
  fun (b:int) : int = a + b

let add10 : int -> int = makeAdder 10
let ex7   : int = add10 5
printfn "add10 5 = %d" ex7
printfn ""




// ============================================

#if ZADATAK
(*
  Analizirati kod i objasniti koji će biti red ispisa i vrijednosti simbola:

  Odgovoriti:

    Da li se kod kompajlira?

    Šta se ispisuje?

    Tipovi foo, f, g?
*)

    let foo a b =
        printf "1"
        let res c = a + b + c
        res
    printf "2"
    let f = foo 4 5
    printf "3"
    let g = f 6
    printf "4"
    g

(*
  kompajlira se.

  tipovi:
  foo : int -> int -> (int -> int)
  f : int -> int
  g : int = 15

redoslijed ispisa: 2, zatim pri foo 4 5 se ne ispisuje “1” (još nije dat c), 
zatim 3, pa pri f 6 postaje potpun poziv → ispiše "1", i na kraju 4 ⇒ "2314".
*)
#endif
// ============================================



#if ZADATAK
(*
Definisati funkciju readAndDouble koja traži unos cijelog broja s tastature,
zatim ispisuje njegovu duplu vrijednost.
Koristiti System.Console.ReadLine() i int.
Funkcija treba imati tip unit -> unit.
*)

let readAndDouble (u : unit) : unit =
    printf "Unesi broj: "
    let n : int = System.Console.ReadLine() |> int
    printfn "Duplo: %d" (2 * n)

// poziv
readAndDouble ()

#endif


// ============================================



#if ZADATAK
(*
Napisati funkciju between koja provjerava da li je broj u opsegu [lo, hi].
Definisati simbol isTeenager pomoću parcijalne aplikacije between
tako da vrati true ako je broj između 13 i 19.
Korištenjem List.filter, pronaći sve tinejdžere iz liste:
*)

let between (lo : int) (hi : int) (x : int) : bool =
    lo <= x && x <= hi

let isTeenager : int -> bool = between 13 19

let ages : int list = [ 5; 12; 14; 19; 21 ]
let teens : int list = ages |> List.filter isTeenager
printfn "%A" teens     // [14; 19]

#endif


// ============================================



#if ZADATAK
(*

*)
#endif


// ============================================



#if ZADATAK
(*

*)
#endif


// ============================================



#if ZADATAK
(*

*)
#endif


// ============================================


