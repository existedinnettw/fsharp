module PizzaPricing

type Pizza =
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza) : int =
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce (innerPizza) -> 1 + pizzaPrice innerPizza
    | ExtraToppings (innerPizza) -> 2 + pizzaPrice innerPizza

let orderPrice (pizzas: Pizza list) : int =
    let priceLi = List.map pizzaPrice pizzas

    List.sum (priceLi)
    + match pizzas.Length with
      | 1 -> 3
      | 2 -> 2
      | _ -> 0
