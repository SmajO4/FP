// Napisati let izraz koji veze "isEven" simbol za lambda
// izraz koji uzima broj te ispituje da li je dati broj
// paran. Lambda nazad vraca boolean. Lambda izraz je
// potrebno anotirati odgovarajucim tipovima.
// Nakon ovoga napisati funkciju isEven koja radi istu 
// stvar kao lambda izraz te je takodjer anotirati tipovima


let n = 10
let isEven : int -> bool = fun x -> x % 2 = 0
isEven n

let isEven2 (x : int) : bool = x % 2 = 0
printfn "%b" (isEven2 10)


// let isEven = fun x -> x % 2 = 0
let isEven3 x = x % 2 = 0
printfn "%b" (isEven3 n)


// ////////////////////////////////

let s x = 
  x % 2 
s(3)

let s2 (x : int) : bool = 
  x % 2 = 0
s2(3)





