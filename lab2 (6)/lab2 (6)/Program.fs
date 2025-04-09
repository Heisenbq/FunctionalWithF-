// For more information see https://aka.ms/fsharp-console-apps
open System
open BinaryTree
open ListTreat

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

let rec frequency list num count =
     match list with
     | [] -> count
     | head::tail -> 
         let newCount = if head = num then count+1 else count
         frequency tail num newCount

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
    Console.WriteLine("Количество нечётных: " + (count_odd arr).ToString())
    Console.WriteLine("частота элемента 3: " + (frequency arr 3 0).ToString())

    let result = most_frequent [1; 2; 2; 3; 3; 3; 4; 4; 4; 4]
    printfn "Most frequent element: %d" result

    let result2 = count_square_elements [4; 16; 25; 5; 36; 10]
    printfn "Count of square elements: %d" result2
    
    let result3 = digit_sum 12345
    printfn "Digit sum of 12345: %d" result3
    
    let result4 = count_divisors 36
    printfn "Count of divisors of 36: %d" result4
    
    let sortedA, sortedB, sortedC = create_tuples [3; 1; 4; 1; 5] [12; 23; 34; 45] [56; 67; 78; 89]
    printfn "Sorted A: %A" sortedA
    printfn "Sorted B: %A" sortedB
    printfn "Sorted C: %A" sortedC
    
    

    0  

