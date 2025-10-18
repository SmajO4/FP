(*
  Napisati let izraz koji ce rezultirati stringom "PARAN"
  ukoliko je broj unutar expr1 zaista paran.
  U suprotnom izraz treba da generise runtime iznimku
*)

let expr1 = 8 
let 0 = expr1 % 2 in "PARAN"

(*
Objašnjenje:

expr1 se vezuje za vrijednost 8.

U sljedećem let izrazu, na lijevoj strani stoji konstanta 0.
S desne strane je izraz expr1 % 2, što vraća ostatak pri dijeljenju sa 2.

Pattern matching ovdje uspijeva samo ako je rezultat modulo jednak 0.
U našem slučaju, 8 % 2 = 0, pa match uspijeva i vraća "PARAN".

Ako bi broj bio neparan (npr. 9), rezultat bi bio 1, pa bi 0 = 1 propao i bacila bi se iznimka.

Intuitivno čitanje:

“Izračunaj ostatak kada se broj podijeli sa 2.
Ako je rezultat tačno nula, reci ‘PARAN’.
Inače, ne može se poklopiti i javi grešku.”

Rezultat:
"PARAN"
*)

