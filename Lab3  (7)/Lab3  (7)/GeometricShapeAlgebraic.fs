module GeometricShapeAlgebraic
open System

type GeometricShapeAlg =
    | RectangleA of width: float * height: float  
    | SquareA of side: float                     
    | CircleA of radius: float                   

let getArea shape =
    match shape with
    | RectangleA (width, height) -> width * height  
    | SquareA side -> side * side                  
    | CircleA radius -> Math.PI * radius * radius  

