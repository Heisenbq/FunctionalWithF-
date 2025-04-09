

open System
open GeometricShape
open GeometricShapeAlgebraic
open IPrint


let checkGeometricShape() =
    let rectangle = Rectangle(5.0, 3.0)


    let square = Square(4.0)


    let circle = Circle(3.0)


    (rectangle :> IPrint).Print()
    (square :> IPrint).Print()
    (circle :> IPrint).Print() 


let checkGeometricShapeAlgebraic() =
    let rectangle = RectangleA (5.0, 3.0)
    let square = SquareA 4.0
    let circle = CircleA 3.0

    
    printfn "Area of Rectangle: %.2f" (getArea rectangle)
    printfn "Area of Square: %.2f" (getArea square)
    printfn "Area of Circle: %.2f" (getArea circle)


[<EntryPoint>]
let main argv =

    


    //checkGeometricShape()
    //checkGeometricShapeAlgebraic()

    0 
