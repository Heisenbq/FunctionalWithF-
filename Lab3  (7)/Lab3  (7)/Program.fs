

open System
open GeometricShape
open IPrint
[<EntryPoint>]
let main argv =

    let rectangle = Rectangle(5.0, 3.0)


    let square = Square(4.0)


    let circle = Circle(3.0)


    (rectangle :> IPrint).Print()
    (square :> IPrint).Print()
    (circle :> IPrint).Print()  

    0 
