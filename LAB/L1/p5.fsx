(*
  Napisati let izraz koji veze simbol concat za lamda izraz
  koji uzima 3 parametra.
  Prva dva parametra su stringovi koje treba spojiti, a treci
  parametar je delimiter izmedju dva strniga.
  Pozvati lambdu u expr2 dijelu let izraza:
  concat "Hello" "World" "_" ispisuje Hello_World
*)

// let concat = fun s1 s2 s3 -> s1 + s3 + s2

let concat = fun (a : string) b delimiter -> a + delimiter + b
concat "Hello" "World" "_"


// let concat a b c = a + c + b

(*
  Objašnjenje:

Imamo simbol concat koji se vezuje za lambda izraz.
Lambda ima tri parametra: a, b i delimiter.
Tip prvog parametra eksplicitno je anotiran kao string.

Tijelo lambde (a + delimiter + b) sabira tri stringa u jedan.
Operator + u F# spaja stringove.

Kada pozovemo concat "Hello" "World" "_",
pattern matching dodjeljuje:
a = "Hello", b = "World", delimiter = "_".

Lambda se izvršava i vraća "Hello_World".

Intuitivno čitanje:

“Definiši funkciju koja prima tri stringa: prvi, drugi i razdjelnik.
Spoji ih redom: prvi + razdjelnik + drugi.
Pozovi je s Hello, World, i underscore.”

Rezultat:
"Hello_World"
*)
