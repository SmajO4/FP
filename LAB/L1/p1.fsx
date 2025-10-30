(* 
   Napisati program koji kreira let izraz koji veze 3 simbola
   za integere (a, b, c) -> (26, 28, 18). Nakon toga koristi 3 
   simbolda da izracuna zajednicke bite integera koristeci 
   AND operator 
*)

// Vezivanje simbola 

(* let a = 26 *)
(* let b = 28 *)
(* let c = 18 *)
(**)
(* let x = a &&& b &&& c *)
(* printfn "%d" x *)


let ((a:float32), b, c) = (26f, 28f, 18f)
let x : int = int a &&& int b &&& int c
printfn "%d" x


(*
Imamo uzorak (a, b, c) koji se koristi u let izrazu.
Ovaj uzorak se podudara s trojkom (26, 28, 18) i tom prilikom
nastaju tri nova simbola: a, b i c.

Zatim se simbol x veže za rezultat izraza a &&& b &&& c.
Operator &&& je bitovni AND i radi samo nad vrijednostima tipa int.
On vraća novu vrijednost koja sadrži samo zajedničke bitove.

Kada pozovemo printfn "%d" x, ispisuje se vrijednost x na ekran


“Raspakuj 26, 28 i 18 u a, b, c.
Izračunaj bitove koji su zajednički kod sva tri broja pomoću AND operatora.
Rezultat upiši u x i ispiši ga.”

Rezultat:
16
*)




