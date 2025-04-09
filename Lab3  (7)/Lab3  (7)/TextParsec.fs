module TextParsec
open FParsec

type Expr =
    | Number of int
    | Add of Expr * Expr
    | Subtract of Expr * Expr

let numberParser: Parser<Expr, unit> =
    pint32 |>> (fun n -> Number n)

let addParser: Parser<Expr, unit> =
    pipe2 numberParser (pchar '+' >>. spaces >>. numberParser) (fun left right -> Add(left, right))

let subtractParser: Parser<Expr, unit> =
    pipe2 numberParser (pchar '-' >>. spaces >>. numberParser) (fun left right -> Subtract(left, right))

let exprParser: Parser<Expr, unit> =
    pipe2 numberParser (many (choice [addParser; subtractParser])) (fun left ops -> 
        List.fold (fun acc op -> 
            match op with
            | Add(l, r) -> Add(acc, r)
            | Subtract(l, r) -> Subtract(acc, r)) left ops
    )

let parseExpression (input: string) =
    let result = run exprParser input
    match result with
    | Success (expr, _, _) -> printfn "Parsed expression: %A" expr
    | Failure (err, _, _) -> printfn "Parse error: %s" err



