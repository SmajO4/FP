// #load "myScript.fsx"
// #define ZADATAK1


#if ZADATAK1a
// Dokazati da vrijedi p/2^q = p >> q.
// Program treba da vraca vrijednost tipa boolean.

      let p : int = 64
      let q : int = 2

      // VAS KOD:

      let lhs : int = p / (1 <<< q)
      let rhs : int = p >>> q
      let res : bool = lhs = rhs;;

#endif


// =========================================================


#if ZADATAK2a
// Dodati svoj kod tako da se kod ispod kompajlira i radi.
// Program treba ispisati random broj od 0 do unesenog.
// Potrebno je anotirati svaki simbol u kodu.
// HINT: System.Random ima funkciju Next koja uzima jedan parametar maxValue i vraca random broj iz [0, maxValue)

      let n : int = System.Console.ReadLine() |> int
      let random : System.Random = System.Random()

      let getRandom (x : int) : (unit -> int) =
          let foo ((): unit) : int = random.Next x
          foo

      let k : int = (getRandom n) ()
      printfn $"Random vrijednost od 0 do {n}: {k}";;
#endif

// =========================================================

#if ZADATAK3a
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
Kompilacija:
Kompajlira se.

foo : int -> int -> int -> (int -> int) (currying: vraća funkciju res).

bar : int -> (int -> int) (parcijalna aplikacija foo 5 4).

bar 4 : (int -> int); (bar 4) 5 : int → tar : int = 8.

Zašto nema greške:

Tipovi su dosljedni: sve su int i funkcije se parcijalno apliciraju korektno.

printf "1" je side-effect koji se desi tek kad je z primljen (odnosno kada se tijelo foo zaista evaluira); prije toga foo 5 4 samo vraća funkciju, ne izvršava račun.

Red ispisa (bitno za razumijevanje evaluacije):

printf "2" → 2

let bar = foo 5 4 → ne ispisuje “1” (još nema z, tijelo nije evaluirano; vraća se funkcija)

printf "3" → 3

let tar = bar 4 5 ≡ (bar 4) 5
– pri bar 4 dobijamo res (nema ispisa)
– pri pozivu res 5 evaluira se tijelo foo (sada je z=4) → ispisuje “1”, izračuna 5 + 4 − 5 + 4 = 8

printf "4" → 4

Konačno: ispis je 2314, tar : int = 8.
*)


#endif

// =========================================================

#if ZADATAK1b
// napisati niz let izraza koji dokazuju
// sljedecu izjavu: 2^q = 1 << q

      let q = 5
      let lhs = (float 2) ** (float q)
      let rhs = 1 <<< q
      let res = (int lhs) = rhs
      printfn "%A" res

      let q : int = 5
      let lhs : int = 1 <<< q   // 2^q
      let rhs : int = 1 <<< q
      let res : bool = lhs = rhs
      printfn "%b" res

#endif

// =========================================================

#if ZADATAK2b
// dodati potreban kod da kompletan kod kompajlira
// definisati funkciju koja ukoliko je broj paran
// ispise paran na ekran i vrati true
// u suprotnom se baca iznimka

    let foo (x : unit -> int) : bool =
      let 0 = x () % 2
      printfn "Paran"
      true

    let enterNum (u:unit) : int =
      printf "Unesite neki broj: "
      System.Console.ReadLine () |> int

    let _ : bool = foo enterNum
#endif


// =========================================================
#if ZADATAK3b
// da li kompajlira
// koji je ispis
// koji su simboli pravilno definisani
// navesti njihov tip i vrijednos

      let foo x y z =
        printf "1"
        let res a =
          x + y - a + z
        res
      printf "2"
      let bar = foo 5 4
      printf "3"
      let tar = bar 4 5
      printf "4"
      tar
(*
Da li se kompajlira?

Da. Svi tipovi se slagaju i parcijalna aplikacija je korektna.

Tipovi simbola

foo : int -> int -> int -> (int -> int)
(curried; nakon tri int argumenta vraća funkciju res : int -> int)

bar : int -> (int -> int)
(bar = foo 5 4, fiksirani x=5, y=4; čeka z, pa vraća funkciju)

tar : int
(tar = (bar 4) 5 → broj)

Red ispisa (precizno)

printf "2" → ispiše 2

let bar = foo 5 4 → nema ispisa (još nema z; tijelo foo se ne evaluira)

printf "3" → ispiše 3

let tar = bar 4 5 se čita kao (bar 4) 5

bar 4 = foo 5 4 4 → sada foo dobija i treći argument z, tijelo se evaluira → ispiše 1, vrati res

(bar 4) 5 = res 5 → izračuna 5 + 4 - 5 + 4 = 8 (bez ispisa)

printf "4" → ispiše 4

Ukupan ispis: 2314
Vrijednost: tar = 8

Zašto baš tako?

Aplikacija je lijevo-asocijativna: (bar 4) 5.

Tijelo curry-ovane funkcije (foo) se ne evaluira dok ne dobije posljednji parametar (z).
Zato foo 5 4 ne ispisuje ništa; tek na bar 4 se ispisuje "1".

res je obična funkcija int -> int bez ispisa; tek računa vrijednost.
*)
#endif

// =========================================================
