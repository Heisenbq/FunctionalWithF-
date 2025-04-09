

open System
open GeometricShape
open GeometricShapeAlgebraic
open IPrint
open Maybe
open TextParsec
open Agent
open VehicleRegistrationPassport


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


let checkLawsMaybe() =
    // Пример Maybe с числом
    let m = Some 5
    let n = None

    // Проверка функтора
    printfn "Identity law (Some 5): %b" (identityLaw m)
    printfn "Composition law (Some 5): %b" (compositionLaw m (fun x -> x + 1) (fun x -> x * 2))
    printfn "Identity law (None): %b" (identityLaw n)

    // Проверка аппликативного функтора
    printfn "Identity law' (Some 5): %b" (identityLaw' m)
    //printfn "Composition law' (Some 5): %b" (compositionLaw' m (fun x -> x + 1) (fun x -> x * 2))

    // Проверка монады
    printfn "Identity Monad law (Some 5): %b" (identityMonadLaw m)
    printfn "Associativity Monad law (Some 5): %b" (associativityLaw m (fun x -> Some (x + 1)) (fun x -> Some (x * 2)))
    
let checkParsec() = 
    let expressions = [
        "5"
        "3 + 4"
        "10 - 2"
        "3 + 4 - 1"
    ]

    expressions |> List.iter parseExpression

let checkAgent() = 
    agent.Post(PrintMessage "Hello, agent!") 
    agent.Post(AddNumbers(3, 4))  
    agent.Post(MultiplyNumbers(5, 6)) 
    System.Threading.Thread.Sleep(1000)

let checkPTS() = 
    let doc1 = VehicleRegistrationPassport("1234", "567890", "Иванов И.И.", "Toyota Camry")
    let doc2 = VehicleRegistrationPassport("1234", "567890", "Петров П.П.", "Honda Civic")
    let doc3 = VehicleRegistrationPassport("4321", "987654", "Сидоров С.С.", "BMW X5")
    
    // Вывод документов на экран
    doc1.PrintDocument()
    printfn ""
    doc2.PrintDocument()
    printfn ""
    doc3.PrintDocument()
    printfn ""
    
    // Сравнение документов
    printfn "Документы doc1 и doc2 одинаковы: %b" (doc1.Equals(doc2))  // true
    printfn "Документы doc1 и doc3 одинаковы: %b" (doc1.Equals(doc3))  // false
    

   


[<EntryPoint>]
let main argv =


    


    //checkGeometricShape()
    //checkGeometricShapeAlgebraic()
    //checkLawsMaybe()
    //checkParsec()
    //checkAgent()
    //checkPTS()


    0 
