// napisati niz let izraza koji dokazuju
// sljedecu izjavu: 2^q = 1 << q

let q = 5

// dodati potreban kod da kompletan kod kompajlira
// definisati funkciju koja ukoliko je broj paran
// ispise paran na ekran i vrati true
// u suprotnom se baca iznimka

//vas kod vodjika
let foo (x: unit -> int) : bool = 
  let 0 = x() % 2 
  printfn "TACNO"
  true

let enterNum (u:unit) : int =
  printf "Unesite neki broj: "
  System.Console.ReadLine () |> int
enterNum |> foo


// da li kompajlira
// koji je ispis
// koji su simboli pravilno definisani
// navesti njihov tip i vrijednos

let foo2 x y z =
  printf "1"
  let res a =
    x + y - a + z
  res
printf "2"
let bar = foo2 5 4
printf "3"
let tar = bar 4 5
printf "4"
tar

// ispis 2314
// tar : int = 8
// foo : x: int -> y: int -> z: int -> (int -> int)
