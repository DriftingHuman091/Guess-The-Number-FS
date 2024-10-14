module Main
open System

[<EntryPoint>]
let main args =
    printf "Guess the number between 1 and 100!\n"
    let number = new Random()
    let numberChosen = number.Next(1, 100)
    let rec check_guess() =
        let mutable guess = 0
        try
            guess <- Console.ReadLine() |> int
        with
        | :? FormatException -> printf "Not a number\n"; check_guess()
        match guess with
        | _ when guess > numberChosen ->
            printf "Lower! \n" ; check_guess()
        | _ when guess < numberChosen ->
            printf "Higher! \n" ; check_guess()
        | _ when guess = numberChosen ->
            printf "You win! \n" 
        | _ -> ()

    check_guess()
    Console.ReadLine() |> ignore
    0