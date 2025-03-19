// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"


let solve (a,b,c) = 
    let D = b*b - 4.0 *a*c in
        ((-b + sqrt(D))/ (2.0 * a) , (-b - sqrt(D))/ (2.0 * a));;
solve(1.0, 2.0, -3.0);;




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