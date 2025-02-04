module ValentinesDay

type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Korean
    | Turkish

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity) : Approval =
    match activity with
    | BoardGame -> No
    | Chill -> No
    | Movie m -> if m = Romance then Yes else No
    | Restaurant r -> if r = Korean then Yes else Maybe
    | Walk km ->
        if km < 3 then Yes
        elif km < 5 then Maybe
        else No
