// For more information see https://aka.ms/fsharp-console-apps
open System

printfn "Hello from F#"


let solve (a,b,c) = 
    let D = b*b - 4.0 *a*c in
        ((-b + sqrt(D))/ (2.0 * a) , (-b - sqrt(D))/ (2.0 * a));;
solve(1.0, 2.0, -3.0);;



let circleArea radius = Math.PI * radius * radius


let cylinderVolume height = circleArea >> (*) height  

let cylinderVolumeCar height radius = height * circleArea radius  



let rec sumOfDigits n =
    if n = 0 then 0  
    else (n % 10) + sumOfDigits (n / 10);;

let sumOfDig n = 
    let rec sumOfDigitsTail n acc =
       if n = 0 then acc
       else sumOfDigitsTail (n/10) (acc + (n%10))
    sumOfDigitsTail n 0 ;;

let colOfDiv n =
    let rec colOfDivTail n acc i =       
        match i with
        | 0 -> acc
        | _ -> colOfDivTail n (acc + (if n % i = 0 then 1 else 0)) (i - 1)
    colOfDivTail n 0 n ;;


let rec Fibonacci n = 
    match n with
        |0 -> 0
        |1 -> 1
        |_ -> Fibonacci(n-1) + Fibonacci(n-2) ;;

let fib n =
    let rec FibonacciTail n a b =
        match n with
        | 0 -> a
        | 1 -> b
        | _ -> FibonacciTail (n - 1) b (a + b)
    FibonacciTail n 0 1 ;;
 
 let chooseFunction isSum =
    if isSum then
        colOfDiv  // Возвращаем функцию для подсчета суммы цифр
    else
        fib ;; 


let funcOfDigits n func initValue= 
    let rec funcOfDigitsTail n acc =
       match n with
       | 0 -> acc
       | _ -> funcOfDigitsTail (n/10) (func acc (n%10))
    funcOfDigitsTail n initValue;;

let funcOfDigitsWithCondition n func initValue boolFunc= 
    let rec funcOfDigitsTail n acc =
       match n with
       | 0 -> acc
       | _ -> if boolFunc (n%10) then funcOfDigitsTail (n/10) (func acc (n%10))
              else funcOfDigitsTail (n/10) acc
    funcOfDigitsTail n initValue;;

funcOfDigits 223 (fun acc digit -> acc + digit) 0;;
funcOfDigits 237 (fun acc digit -> acc * digit) 1;;
funcOfDigits 723 (fun acc digit -> min acc digit) System.Int32.MaxValue;;
funcOfDigits 723 (fun acc digit -> max acc digit) System.Int32.MinValue;;

funcOfDigitsWithCondition 22345 (fun acc digit -> acc + digit) 0 (fun a -> a>3);;
       

//[<EntryPoint>]
//let main argv =
    
//    let res = fib 19
//    printfn "%i" res
//    //printf "Введите радиус круга: "
//    //let radius = Double.Parse(Console.ReadLine())

//    //printf "Введите высоту цилиндра: "
//    //let height = Double.Parse(Console.ReadLine())

//    ////let volume = cylinderVolume height radius  
//    ////printfn "Объем цилиндра: %f" volume

//    //let volumeCar = cylinderVolume height  
//    //let volume = volumeCar radius
//    //printfn "Объем цилиндра: %f" volume

//    0  







//let solve (a,b,c) = 
//    let D = b*b - 4.0 *a*c in
//        ((-b + sqrt(D))/ (2.0 * a) , (-b - sqrt(D))/ (2.0 * a))
//in solve(1.0 , 2.0, -3.0)

//(-2.0 + sqrt(2.0*2.0 - 4.0*(-3.0))) / 2.0 ;;

//let a =1.0 in
//    let b = 2.0 in
//            let c = -3.0 in
//                let D = b*b - 4.0 * a * c in
//                    ((-b + sqrt(D))/ (2.0 * a) , (-b - sqrt(D))/ (2.0 * a)) ;;

//let a =1.0 in
//    let b = 2.0 in
//            let c = -3.0 in
//                let D = b*b - 4.0 * a * c in
//                    [(-b + sqrt(D))/ (2.0 * a) , (-b - sqrt(D))/ (2.0 * a)] ;;

//let solve (a,b,c) = 
//    let D = b*b - 4.0 *a*c in
//        ((-b + sqrt(D))/ (2.0 * a) , (-b - sqrt(D))/ (2.0 * a));;
//solve(1.0, 2.0, -3.0);;


//let solve (a,b,c) = fun(a,b,c) -> 
//    let D = b*b - 4.0 *a*c
//    ((-b + sqrt(D))/ (2.0 * a) , (-b - sqrt(D))/ (2.0 * a))
//in solve(1.0 , 2.0, -3.0);;