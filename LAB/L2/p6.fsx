// Napisati funkciju makeDerivative koja uzima 2 parametra 
// Prvi parametar je dx, drugi parametar je funkcija f koja 
// uzima float i vraca float. 
// makeDerivative vraca nazad funkciju koja predstavlja prvi
// izvod funkcije f.

(*
  Izvod:
    lim ( (f(x + dx) - f(x) ) / dx )
  dx -> oo
*)

let x = 3f

let makeDerivative (dx : float32) (f : float32 -> float32) = 
  ((f (x + dx) - f x) / dx)

let func y = 3f * y * y

printfn "Izvod je %f" (makeDerivative 0.00001f func)



