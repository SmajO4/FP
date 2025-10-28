// Napisati funkciju discount koja uzima postotak i cijenu.
// Funkcija aplicira popust u datim procentima na datu cijenu
// i vraca nazad cijenu sa apliciranim popustom.

// Definirati simbol studentDiscount koji uzima cijenu i
// aplicira fiksni popust od 15%. Za definiranje simbola
// koristiti parcijalnu aplikaciju funkcije discount.

// Sve izraze anotirati tipovima.


let discount percent price =
  price - (price * percent) / 100.

let studentDiscount = discount 15

// TEST:
let prices = [ 1299.; 2000.; 499. ]
let discounted = prices |> List.map studentDiscount
printfn "%A" discounted
