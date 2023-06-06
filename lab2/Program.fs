// Potrzebne kiedy chce się wczytaj dane od urzytkownika
open System

//zad 1
//wczytywanie danych od urzytkownika
let wartosc = System.Console.ReadLine()

match wartosc with
| "1" -> printfn "Wprowadziles 1"
| "2" -> printfn "Wprowadziles 2" 
| "3" -> printfn "Wprowadziles 3" 
| "4" -> printfn "Wprowadziles 4" 
| _ -> printfn "Wprowadziles inna wartosc niz 1,2,3 lub 4"

//zad 2
let  (w1: string, w2:string) =  (System.Console.ReadLine(), System.Console.ReadLine())

let (w1Int: int, w2Int: int) = (int w1, int w2)

let sprawdz ((a:int), (b:int)) = 
    if a > b then
        1
    elif a < b then
        2
    else 
        3

match sprawdz(w1Int, w2Int) with
| 1 -> printfn "Pierwsza wieksza od drugiej"
| 2 -> printfn "Druga wieksza od pierwszej"
| 3 -> printfn "Rownne"
| _ -> printfn "blad"