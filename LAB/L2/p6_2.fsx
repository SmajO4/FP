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

let makeDerivative (dx: float) (f: float -> float) : (float -> float) = 
  let f' x =
    (f (x + dx) - f (x)) / dx
  f'

// iz makeDerivative cemo vratiti funkciju


// definisimo nekakvu funkciju
let xsquared x = x * x

// nadjimo izvod funkcije 
let xsquaredderiv = makeDerivative 0.000001 xsquared


let xsq10 = xsquared 10
let xderiv10 = xsquaredderiv 10

// ubrizgavanje varijabli direktno u string
printf $"VAL: {xsq10} Deriv: {xderiv10}"

(*
  makeDerivative je funkcija višeg reda: prima dx i funkciju f, a vraća novu funkciju f' : float -> float.

  f' je closure: „zatvara“ (pamti) vrijednosti dx i f čak i nakon što makeDerivative završi—zato je 
  kasnije možeš zvati kao običnu funkciju nad bilo kojim x.
*)
