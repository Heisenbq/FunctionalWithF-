module Agent

open System


type Message =
    | PrintMessage of string
    | AddNumbers of int * int
    | MultiplyNumbers of int * int

let agent = MailboxProcessor.Start(fun inbox ->
    let rec loop() = 
        async {
            // Ожидаем сообщения
            let! msg = inbox.Receive()
            match msg with
            | PrintMessage text ->
                printfn "Received message: %s" text
            | AddNumbers (a, b) ->
                printfn "Sum of %d and %d is: %d" a b (a + b)
            | MultiplyNumbers (a, b) ->
                printfn "Product of %d and %d is: %d" a b (a * b)
            
            // Рекурсивно продолжаем ожидать сообщения
            return! loop()
        }
    loop()  // Запуск 
)

