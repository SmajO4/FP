// Dokazati da vrijedi p/2^q = p >> q.
// Program treba da vraca vrijednost tipa boolean.

let p = 64
let q = 2

// VAS KOD OVDJE

(* let rhs = p >>> q *)
(* let lhs = int(float32 p / (2f ** float32(q))) *)
(* lhs = rhs *)

let rhs = p >>> q
let lhs = p / (1 <<< q)
lhs = rhs


