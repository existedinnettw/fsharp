module GuessingGame

let reply (guess: int) : string =
    match guess with
    | 42 -> "Correct"
    | 41
    | 43 -> "So close"
    | i when i < 41 -> "Too low"
    | _ -> "Too high"
