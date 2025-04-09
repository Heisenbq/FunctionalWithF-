module Maybe

type Maybe<'a> =
    | Some of 'a
    | None

module Maybe =

    let map f m =
        match m with
        | Some x -> Some (f x)
        | None -> None

    let apply mf m =
        match mf, m with
        | Some f, Some x -> Some (f x)
        | _ -> None

    let bind f m =
        match m with
        | Some x -> f x
        | None -> None

let identityLaw maybe =
    Maybe.map id maybe = maybe

let compositionLaw maybe f g =
    Maybe.map (fun x -> g (f x)) maybe = Maybe.map g (Maybe.map f maybe)

let identityLaw' maybe =
    Maybe.apply (Some id) maybe = maybe



//let compositionLaw' maybe f g =
//    Maybe.apply (Maybe.apply (Some f) (Maybe.map g maybe)) maybe = Maybe.apply (Some (fun x -> f (g x))) maybe



let identityMonadLaw maybe =
    Maybe.bind (fun x -> Some x) maybe = maybe

let associativityLaw maybe f g =
    Maybe.bind (fun x -> Maybe.bind g (f x)) maybe = Maybe.bind g (Maybe.bind f maybe)





