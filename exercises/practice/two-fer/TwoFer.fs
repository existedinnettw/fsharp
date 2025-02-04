module TwoFer

let matchTarget (input: string option): string =
    match input with 
        | Some(input) -> input
        | None -> "you"

let twoFer (input: string option): string = 
    $"One for {matchTarget input}, one for me."