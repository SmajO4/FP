(*
  Napisati let izraz koji ce dokazati da operator left shift radi
  operaciju p<<q  <==>  p = p * 2 ^ q (koristiti ** operator)
*)

let p = 8
let q = 2


let lhs = p <<< q
let rhs = int32 (float32 p * 2f ** float32 q)
lhs = rhs

(*
Objašnjenje:

p i q su obične integer konstante.
p = 8, q = 2.

Simbol lhs se vezuje za rezultat izraza p <<< q.
Operator <<< je bitovni pomak ulijevo.
Pomak ulijevo za q mjesta znači množenje sa 2^q.
Dakle, 8 <<< 2 znači „pomjeri bitove 8 za dva mjesta ulijevo“ → 8 * 4 = 32.

rhs se računa kao p * (1 <<< q) što je isto što i p * 2^q.
Dakle, 1 <<< 2 = 4, pa je rhs = 8 * 4 = 32.

Izraz lhs = rhs poredi dvije vrijednosti i vraća true jer su jednake.

Intuitivno čitanje:

“Pomjeri 8 ulijevo za 2 bita.
Pomnoži 8 sa 2 na kvadrat.
Uporedi rezultate i vidi da su isti.”

Rezultat:
true
*)
