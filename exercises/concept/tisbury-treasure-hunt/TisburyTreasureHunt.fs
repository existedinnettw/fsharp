module TisburyTreasureHunt

let getCoordinate (line: string * string) : string = snd line

let convertCoordinate (coordinate: string) : int * char =
    (int coordinate[0] - int '0', coordinate[1])

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool =
    let (_, coordinates: int * char, _) = ruisData
    coordinates = (azarasData |> snd |> convertCoordinate)

let createRecord
    (azarasData: string * string)
    (ruisData: string * (int * char) * string)
    : (string * string * string * string) =
    if compareRecords azarasData ruisData then
        let (locationName, coordinates, quandrant) = ruisData
        (snd azarasData, locationName, quandrant, fst azarasData)
    else
        ("", "", "", "")
