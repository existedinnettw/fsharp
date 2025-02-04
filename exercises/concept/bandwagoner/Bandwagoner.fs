module Bandwagoner

type Coach = { Name: string; FormerPlayer: bool }
type Stats = { Wins: int; Losses: int }

type Team =
    { Name: string
      Coach: Coach
      Stats: Stats }

let createCoach (name: string) (formerPlayer: bool) : Coach =
    { Name = name
      FormerPlayer = formerPlayer }

let createStats (wins: int) (losses: int) : Stats = { Wins = wins; Losses = losses }

let createTeam (name: string) (coach: Coach) (stats: Stats) : Team =
    { Name = name
      Coach = coach
      Stats = stats }

let replaceCoach (team: Team) (coach: Coach) : Team = { team with Coach = coach }

let isSameTeam (homeTeam: Team) (awayTeam: Team) : bool = homeTeam = awayTeam

let rootForTeam (team: Team) : bool =
    match team with
    | _ when team.Coach.Name = "Gregg Popovich" -> true
    | _ when team.Coach.FormerPlayer = true -> true
    | _ when team.Name = "Chicago Bulls" -> true
    | _ when team.Stats.Wins >= 60 -> true
    | _ when team.Stats.Losses > team.Stats.Wins -> true
    | _ -> false
