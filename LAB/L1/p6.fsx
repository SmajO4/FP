(*
  Napisati let izraz koji veze "isEven" simbol za lambdu
  izraz koji uzima broj te ispituje da li je dati broj 
  paran.
  Lamda nazad vraca boolean.
  Lambda izraz je potrebno anotirati odgovarajucim tipovima.
  Nakon ovoga napisati funkciju isEven koja radi istu stvar
  kao lambda izraz te je takodjer anotirati tipovima.
*)

(* let n = 9 *)
(* let isEven = fun n -> (n % 10) = 0 in isEven n *)

// Lambda izraz sa anotacijom tipova
let isEven : int -> bool = fun (n:int) -> n % 2 = 0

// Testiranje lambde
isEven 8      // true
isEven 5      // false


// Ista funkcionalnost, ali definisana kao imenovana funkcija
let isEven2 (n:int) : bool = n % 2 = 0

// Testiranje funkcije
isEven2 10    // true
isEven2 3     // false



(* (fun isEven -> n % 10 = 0) n *)
(*

// Lambda izraz sa anotacijom tipova
let isEven : int -> bool = fun (n:int) -> n % 2 = 0

// Testiranje lambde
isEven 8      // true
isEven 5      // false


// Ista funkcionalnost, ali definisana kao imenovana funkcija
let isEven2 (n:int) : bool = n % 2 = 0

// Testiranje funkcije
isEven2 10    // true
isEven2 3     // false



Objašnjenje:

Simbol isEven se vezuje za lambda izraz koji uzima jedan parametar n tipa int.

Lambda vraća rezultat logičkog izraza n % 2 = 0, što je true ako je n paran.

Tip lambde je eksplicitno anotiran kao int -> bool.

Kada pozovemo isEven n s n = 9, rezultat je false.

Intuitivno čitanje:

“Definiši funkciju koja prima broj i vraća true ako je paran, false ako nije.
Testiraj je s devetkom – dobićeš false.”

Rezultat:
false
*)
