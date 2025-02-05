module InterestIsInteresting

let interestRate (balance: decimal) : single =
    match balance with
    | _ when balance < 0m -> 3.213f
    | _ when balance < 1000m -> 0.5f
    | _ when balance < 5000m -> 1.621f
    | _ -> 2.475f

let interest (balance: decimal) : decimal =
    balance * decimal (interestRate balance) * 0.01m

let annualBalanceUpdate (balance: decimal) : decimal = balance + interest balance

let amountToDonate (balance: decimal) (taxFreePercentage: float) : int =
    match balance with
    | _ when balance < 0m -> 0
    | _ ->
        int (
            balance
            * decimal (taxFreePercentage * 2.0)
            * 0.01m
        )
