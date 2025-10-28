// Napisati funkciju between koja uzima tri integer-a
// (lo, hi i x) i provjerava da li je argument x izmedju
// vrijednosti lo i hi, ukljucujuci obje vrijednosti.

// Nakon toga definirati simbol isWorkingClass koji
// uzima jedan integer i vraca boolean. isWorkingClass
// vraca nazad true ukoliko je integer izmedju 22 i 65.
// isWorkingClass treba biti definiran parcijalnom
// aplikacijom funkcije between.
//
// Sve izraze anotirati tipovima.

let between (lo : int) hi x =
  lo <= x && x <= hi

let isWorkingClass = between 22 65  

// TEST:
let ages = [ 12; 18; 25; 130; 67; 0 ]
let workingClasses = ages |> List.filter isWorkingClass
printfn "%A" workingClasses
