(*
Napisati funkciju koja racuna cijenu potrosene eleketricne energije.

Cijena po kWh se racuna na osnovu kolicine potrosene energije

Postoje 4 opsega potrosnje

  Opseg A: 0 - 100 kWh - 0.1KM po kWh
  Opseg B: 101 - 200kWh - 0.15KM po kWh
  Opseg C: 201 - 500kWh - 0.2KM po kWh
  Opseg D: preko 500kWh - 0.25 po kWh

  Dodatno za preko 300kWh potrosnje dodati 5 KM na ukupnu cijenu
*)

let racun (potrosnja : float) : float = 
  match potrosnja with 
  | x when x <= 0. -> 0.
  | x when x <= 100. -> 0.1 * x 
  | x when x <= 200. -> 0.15 * x
  | x when x <= 300. -> 0.2 * x 
  | x when x <= 500. -> 0.25 * x + 5.
  | _ -> 0.25 * potrosnja + 5.

let input() = System.Console.ReadLine() |> float

input () |> racun |> printfn "%f"




(* let foo ( potrosnja : float ) : float =  *)
(*   if potrosnja <= 0 then  *)
(*     0.0 *)
(*   elif potrosnja <= 100. then *)
(*     potrosnja * 0.1  *)
(*   elif potrosnja <= 200. then *)
(*     potrosnja * 0.15 *)
(*   elif potrosnja <= 500 then  *)
(*     if potrosnja <= 300. then *)
(*       potrosnja * 0.2 *)
(*     else  *)
(*       potrosnja * 0.2 + 5.0 *)
(*    else  *)
(*      potrosnja * 0.25 + 5.0 *)
