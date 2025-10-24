// Napisati funkciju between koja uzima tri integer-a
// (lo, hi i x) i provjerava da li je argument x izmedju
// vrijednosti la i hi, ukljucujuci obje vrijednosti.

// Nakon toga definirati simbol isWorkingClass koji 
// uzima jedan integer i vraca boolean.
// isWorkingClass vraca nazad true ukoliko je integer
// izmedju 22 i 65.

// isWorkingClass treba biti definiran parcijalnom 
// aplikacijom funkcije between

// Sve izraze anotirati tipovima

// 1️⃣ Definicija funkcije between
let between (lo : int) (hi : int) (x : int) : bool =
    lo <= x && x <= hi

// 2️⃣ Parcijalna aplikacija
// between očekuje 3 argumenta: lo, hi, x
// Ako unaprijed zadamo lo = 22 i hi = 65,
// dobijamo novu funkciju koja čeka samo x.
let isWorkingClass : int -> bool = between 22 65

// 3️⃣ Test
let ages : int list = [ 12; 18; 25; 130; 67; 0 ]
let workingClasses : int list = ages |> List.filter isWorkingClass
printfn "%A" workingClasses



