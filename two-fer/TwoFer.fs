module TwoFer

let getOrDefault (defaultValue: 'a) (input: 'a option): 'a = 
    match input with 
    | Some value -> value 
    | None -> defaultValue

let twoFer (input: string option): string = 
    let name: string = getOrDefault "you" input 
    sprintf "One for %s, one for me." name
