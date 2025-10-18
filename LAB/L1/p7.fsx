// Zasto se dati izraz ne kompajlira?

let foo = fun x y -> x * y
let _ = foo 5.4 6.1
foo 7.2f 8.4f

(*
imamo simbol foo koji se veze za lambda izraz koji uzima dva parametra.

foo je uzorak koji se veze za lambda izraz sa dva parametra i vraca nazad 
neku vrijednost.

Ova lambda mnozi dvije vrijednosti.

Nakon toga imamo instanciranje lambda izraza sa 5.4 i 6.1

Kada vidimo _, to semanticki znaci da nas ne zanima rezultat.

Kada se god veze nesto za _, to znaci da nas u opstem slucaju ne interesuje rezultat.

Mi smo naucili da za decimalne brojeve imamo float i double.

Dakle vec smo instancirali nasu funkciju sa float32, i onda pokusavamo pozvati istu
tu funkciju sa float (float64), tj double.

Zbog toga je greska u kompajliranju.
*)


(*
Objašnjenje:

Simbol foo se vezuje za lambda izraz koji uzima dva parametra x i y i vraća x * y.
U ovom trenutku tip foo je neodređen (generičan) – još nije zaključeno da li su x i y float, int, float32 itd.

Kada prvi put pozovemo foo 5.4 6.1, F# zaključi tip:
5.4 i 6.1 su po defaultu float (tj. double),
pa se foo fiksira kao funkcija tipa float -> float -> float.

Linija let _ = foo 5.4 6.1 znači „izvrši foo, ali me rezultat ne zanima“.

U sljedećem pozivu foo 7.2f 8.4f, argumenti su float32 (oblikovani sufiksom f).
Ovdje dolazi do konflikta tipova, jer se foo već „zaključao“ na float.
F# ne može automatski konvertovati između float i float32, pa prijavi grešku.

Intuitivno čitanje:

“Imam funkciju koja množi dva broja.
Prvi put je pozivam s float vrijednostima, pa F# zaključi da je tip float.
Drugi put pokušavam s float32, ali tip više ne odgovara —
zato se program ne kompajlira.”
*)


