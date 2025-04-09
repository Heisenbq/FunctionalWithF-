// For more information see https://aka.ms/fsharp-console-apps
open System

let readList n = 
    let rec readListRec n acc =
        match n with 
        | 0 -> acc
        | _ -> 
            let el = Console.ReadLine() |> int
            let newAcc = acc@[el]
            readListRec (n-1) newAcc
    readListRec n []

let rec printList list = 
    match list with
    | [] -> ()
    | head :: tail -> 
            Console.WriteLine(head.ToString())
            printList tail
            
let rec reduce list (f:(int->int ->int)) (p:(int->bool)) acc =

    match list with
    | [] -> acc
    | head :: tail ->
        let newAcc = if p head then f acc head else acc
        reduce tail f p newAcc


let minElOfList list = 
    reduce list min (fun el -> true) Int32.MaxValue

let sum_even list = reduce list (+) (fun a -> a%2 = 0) 0

let count_odd list = reduce list (fun a b -> a+1) (fun a -> a%2 = 1) 0

[<EntryPoint>]
let main argv =

    Console.Write("Введите количество элементов: ")
    let n = Console.ReadLine() |> int

    Console.WriteLine("Введите элементы списка:")
    let arr = readList n
    

    Console.WriteLine("Ваш список:")
    printList arr

    Console.WriteLine("Минимальный элемент списка: " + (minElOfList arr).ToString())
    Console.WriteLine("Сумма чётных: " + (sum_even arr).ToString())
    Console.WriteLine("Количество нечётных:" + (count_odd arr).ToString())


    0  

