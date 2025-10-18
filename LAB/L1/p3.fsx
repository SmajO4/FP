(*
  Napisati let izraz koji ce rezultirati stringom "SAMOGLASNIK"
  ukoliko expr1 (char) sadrzi samoglasnik.
  U suprotnom, izraz treba da generise runtime iznimku.
*)

let expr1 = 'e'
let 'a'|'e'|'i'|'o'|'u' = expr1 in "SAMOGLASNIK"

(*
Objašnjenje:

Simbol expr1 se vezuje za karakter 'e'.

U drugom let izrazu, koristimo OR pattern:
'a' | 'e' | 'i' | 'o' | 'u'
To znači: „uzorak će uspjeti ako se vrijednost podudari sa barem jednim od navedenih karaktera.“

Ovdje se uzorak podudara jer je expr1 = 'e'.

Kada se pattern matching uspješno završi, let izraz vraća "SAMOGLASNIK".

Da expr1 nije bio samoglasnik, došlo bi do iznimke u runtime-u (pattern match failure).

Intuitivno čitanje:

“Usporedi karakter sa listom samoglasnika.
Ako je jedan od njih — reci ‘SAMOGLASNIK’.
Ako nije — sruši se, jer uzorak ne odgovara.”

Rezultat:
"SAMOGLASNIK"
*)




