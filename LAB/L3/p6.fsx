// Napisati funkciju calcNums koja uzima dva broja (double tipa) i
// string koji predstavlja operaciju koju treba izvesti.
// Funkcija nazad vraca string koji predstavlja izvedenu operaciju
// ili error poruku ukoliko operacija nije uspjela (dijeljenje sa 0
// ili nevalidna operacija).
// Funkcija treba da podrzava operacije "add", "sub", "mul" i "div"
// Primjer: calcNums 10.0 5.0 mul -> "10.0 * 5.0 = 50.0"


let calcNums (x:float) (y:float) (op:string) : string = 
  if op = "add" then
    $"{x} + {y} = {x+y}"
  elif op = "sub" then
    $"{x} - {y} = {x-y}"
  elif op = "mul" then
    $"{x} * {y} = {x*y}"
  elif op = "div" then
    if y = 0 then 
      "Dijeljenje sa nulom nije dozvoljeno"
    else
      $"{x} / {y} = {x/y}"
  else 
    "Operacija nije podrzana"

(* let calcNums (x:float) (y:float) (op:string) : string =  *)
(*   match op with  *)
(*   | "add" -> $"{x} + {y} = {x+y}" *)
(*   | "sub" -> $"{x} - {y} = {x-y}" *)
(*   | "mul" -> $"{x} * {y} = {x*y}" *)
(*   | "div" when y = 0 -> "Dijeljenje sa nulom nije dozvoljeno" *)
(*   | "div" -> $"{x} / {y} = {x/y}" *)
(*   | _ -> "Operacija nije podrzana" *)

let resultAdd = calcNums 10.0 5.0 "add"
let resultSub = calcNums 10.0 5.0 "sub"
let resultMul = calcNums 10.0 5.0 "mul"
let resultDiv = calcNums 10.0 5.0 "div"
let resultDivByZero = calcNums 10.0 0.0 "div"
let resultInvalid = calcNums 10.0 5.0 "mod" // Invalid operation
printfn "%s" resultAdd
printfn "%s" resultSub
printfn "%s" resultMul
printfn "%s" resultDiv
printfn "%s" resultDivByZero
printfn "%s" resultInvalid
calcNums 10.0 5.0 "div" |> ignore
