module GeometricShape
open System
open IPrint

[<AbstractClass>]
type GeometricShape() =
    abstract member GetArea : unit -> float

    override this.ToString() =
        sprintf "Area: %.2f" (this.GetArea())


type Rectangle(width: float, height: float) =
    inherit GeometricShape()
    
    member val Width = width with get, set
    member val Height = height with get, set
    
    override this.GetArea() = this.Width * this.Height


    override this.ToString() =
        sprintf "Rectangle: Width = %.2f, Height = %.2f, Area = %.2f" this.Width this.Height (this.GetArea())

    interface IPrint with
        member this.Print() = printfn "%s" (this.ToString())



type Square(side: float) =
    inherit Rectangle(side, side)

    override this.ToString() =
        sprintf "Square: Side = %.2f, Area = %.2f" this.Width (this.GetArea())

    interface IPrint with
        member this.Print() = printfn "%s" (this.ToString())


type Circle(radius: float) =
    inherit GeometricShape()

    member val Radius = radius with get, set

    override this.GetArea() = Math.PI * this.Radius * this.Radius

    override this.ToString() =
        sprintf "Circle: Radius = %.2f, Area = %.2f" this.Radius (this.GetArea())

    interface IPrint with
        member this.Print() = printfn "%s" (this.ToString())

