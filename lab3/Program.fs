//zad 1
type Lista<'a> =
 | Pusta
 | Wezel of 'a*Lista<'a>

let glowa = 
    function
    | Pusta -> failwith "Nie mozna pobrac glowy z listy pustej"
    | Wezel(glowa,_) -> glowa

let ogon =
    function
    | Pusta -> failwith "Nie mozna pobrac ogona z listy pustej"
    | Wezel(_,ogon) -> ogon


let nPierwszych n =
    let rec pomocnicza i acc =
        if i > n then
            acc
        else
            let nowyAcc = 
                match acc with
                | Pusta -> Wezel(i, Pusta)
                | _ -> Wezel(i, acc)
            pomocnicza (i + 1) nowyAcc
    pomocnicza 1 Pusta

let rec wypiszListe =
    function
    | Pusta -> ()
    | Wezel(x, Pusta) -> printfn "%d" x
    | Wezel(x, xs) ->
        printf "%d, " x
        wypiszListe xs

let lista = nPierwszych 5
wypiszListe lista

let rec silnia n =
    if n <= 1 then
        1
    else
        n * silnia (n - 1)

let wariancja n k =
    if n < k then
        invalidArg "k" "k nie może być większe od n"
    else
        silnia n / silnia (n - k)

let n = 2
let k = 3
let wynik = wariancja n k
printfn "Wariancja dla n=%d i k=%d wynosi %d" n k wynik
// Wynik: Wariancja dla n=5 i k=3 wynosi 60
