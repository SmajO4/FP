// Dokazati da vrijedi p/2^q = p >> q.
// Program treba da vraca vrijednost tipa boolean.

let p = 64
let q = 2

// VAS KOD OVDJE


// Dodati svoj kod tako da se kod ispod kompajlira i radi.
// Program treba ispisati random broj od 0 do unesenog.
// Potrebno je anotirati svaki simbol u kodu.
// HINT: System.Random ima funkciju Next koja uzima jedan parametar maxValue i vraca random broj iz [0, maxValue)

let n: int = System.Console.ReadLine() |> int
let random: System.Random = System.Random()

// VAS KOD OVDJE

let k: int = n |> getRandom <| ()
printfn $"Random vrijednost od 0 do {n}: {k}"

// PITANJE
// Da li se kod ispod kompajlira?
// Detaljno objasniti svoj odgovor.
// Oznaciti tipove svih definisanih simbola.

let foo x y =
    printf "9"
    x + y + 2

printf "0"
let bar = foo 2
printf "7"
let tar = bar 5
printf "2"
tar

(*
  Kod se kompajlira i ispisuje 0792.
  
  foo je curryed funkcija koja "uzima dva argumenta", tj. foo je funkcija viseg reda
  x i y se sabiraju sa 2, sto je vrijednost tipa int
  iz toga zakljucujemo da su x i y tipa int
  ukoliko ne bi bili tipa int, kod se ne bi kompajlirao
  buduci da je x+y+2 zadnja linija u funkciji foo, to je ujedno i povratna vrijednost i tipa je int
  znaci, x je int, y je int i foo vraca int, pa na osnovu toga zakljucujemo tip za foo
  foo je tipa int -> int -> int
  
  printf "0" ispisuje 0 na ekran u istom redu i vraca unit
  
  bar je vrijednost dobivena aplikacijom funkcije foo na vrijednost 2
  2 se veze za x (iz foo), zakljucujemo da je to parcijalna aplikacija (jer se simbol y nije vezao),
  te takodjer zakljucujemo da je bar closure
  dakle, bar je funkcija, i to int -> int
  
  printf "7" ispisuje 7 na ekran u istom redu i vraca unit
  
  tar je vrijednost dobivena aplikacijom bar na vrijednost 5
  5 se veze za y (iz foo)
  buduci da su sada svi simboli iz foo vezani za neku vrijednost, zakljucujemo da je ovo potpuna aplikacija
  buduci da se desila potpuna aplikacija, izvrsava se tijelo funkcije
  printf "9" ispisuje 9 na ekran i vraca unit
  x + y + 2 je 2 + 5 + 2 sto je 9
  dakle, tar je tipa int vrijednosti 9
  
  printf "2" ispisuje 2 na ekran u istom redu
  
  tar samo vraca vrijednost 9 koja je tipa int
 *)
