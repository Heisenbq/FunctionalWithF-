

open System
//open GeometricShape
open IPrint


type GeometricShape =
    | Rectangle of width: float * height: float  
    | Square of side: float                     
    | Circle of radius: float                   

let getArea shape =
    match shape with
    | Rectangle (width, height) -> width * height  
    | Square side -> side * side                  
    | Circle radius -> Math.PI * radius * radius  

[<EntryPoint>]
let main argv =

    let rectangle = Rectangle (5.0, 3.0)
    let square = Square 4.0
    let circle = Circle 3.0

    printfn "Area of Rectangle: %.2f" (getArea rectangle)
    printfn "Area of Square: %.2f" (getArea square)
    printfn "Area of Circle: %.2f" (getArea circle)

    0 
