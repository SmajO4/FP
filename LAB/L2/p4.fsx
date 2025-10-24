// Napisati funkciju discount koja uzima postotak i cijenu.
// Funkcija aplicira popust u datim procentima na datu cijenu 
// i vraca nazad cijenu sa apliciranim popustom.

// Definirati simbol studentDiscount koji uzima cijenu i 
// aplicira fiksni popust od 15%. Za definiranje simbola 
// koristiti parcijalnu aplikaciju funkcije discount.

// Sve izraze anotirati tipovima



// 1️⃣ Funkcija discount
let discount (percent : float) (price : float) : float =
    price - (price * percent / 100.0)

// 2️⃣ Parcijalna aplikacija za studentDiscount
let studentDiscount : float -> float = discount 15.0

// 3️⃣ Test
let prices : float list = [ 100.0; 250.0; 999.99; 15.0 ]
let discounted : float list = prices |> List.map studentDiscount

printfn "%A" discounted


(*
let discount (percent : float) (price : float) : float =
  let popust = price * ((100. - percent) / 100.)
  popust

let studentDiscount price = discount 15 price

// TEST:
let prices = [ 1299. ; 2000.; 499. ] 
let discounted = prices |> List.map studentDiscount
printfn "%A" discounted
*)
