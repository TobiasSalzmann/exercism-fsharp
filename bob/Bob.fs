module Bob

open System

let isYelling(input: string): bool = not (String.exists Char.IsLower input) && String.exists Char.IsUpper input

let isQuestion(input: string): bool = input.EndsWith("?")

let isSilent(input: string): bool = Seq.isEmpty input

let response (input: string): string = 
    let trimmedInput = input.Trim()
    if isSilent trimmedInput then "Fine. Be that way!"
    elif isYelling trimmedInput && isQuestion trimmedInput then "Calm down, I know what I'm doing!"
    elif isYelling trimmedInput then "Whoa, chill out!" 
    elif isQuestion trimmedInput then "Sure." 
    else "Whatever."