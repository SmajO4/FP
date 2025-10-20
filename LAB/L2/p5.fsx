// Napisati funkciju apply koja uzima funkciju foo i integer x

// Funkcija foo uzima int i vraca nazad int.
// apply treba da aplicira x nad funkcijom foo, te 
// rezultat ponovo pomnozi sa vrijednosti x.

// Napisati test za datu funkciju i sve izraze anotirati tipovima.


let apply (foo : int -> int) (x : int) =
  foo x * x

let bar y =
  y * y

apply bar 12

(* let apply (foo: int -> int) (x:int) : int = *)

// apply je funkcija viseg reda koja uzima funkciju kao argument

(*
ALTERNATIVNO

  let apply = fun foo x -> foo x * x

ILI
  
  let apply = fun foo -> (fun x -> foo x * x)

*)



(*
Definisi funkciju apply koja prima dva argumenta: 
    
    - foo funkcija, nesto sto moze da se pozove
    - x, neki broj (ili generalno neka vrijednost)

apply poziva foo sa argumentom x, dobije rezultat i 
zatim taj rezultat mnozi sa x



bar je obicna funkcija kvadriranja



apply bar 12

    foo se vezuje za bar, a x za 12

U tijelu funkcije apply pise:
  
    foo x * x  →  bar 12 * 12

Izracunamo bar 12 i dobijemo 

  144 * 12 = 1728


*)




(* let n = 5 *)
(* let apply : (int -> int) -> int = fun foo -> (foo n) * n *)
(* apply (fun x -> x * 3) *)
