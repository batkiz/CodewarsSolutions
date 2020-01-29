// CodeWars solutions in fsharp
module EightKyu

// https://www.codewars.com/kata/57d9951f3c3f9666e9000017
// Write a function to determine if a list is a palindrome.
let is_palindrome list = list = (List.rev list)

// https://www.codewars.com/kata/57a4d500e298a7952100035d
// Complete the function which converts hex number (given as a string) to a decimal number.
let hexToDec s =
    ("0x" + s)
    |> int
    |> float

// https://www.codewars.com/kata/57a429e253ba3381850000fb
// Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
let bmi weight height =
    let bmi: float = (weight / (height * height))
    match bmi with
    | bmi when bmi <= 18.5 -> "Underweight"
    | bmi when bmi <= 25.0 -> "Normal"
    | bmi when bmi <= 30.0 -> "Overweight"
    | _ -> "Obese"

// https://www.codewars.com/kata/5ae62fcf252e66d44d00008e
// Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ().
let expressionMatter (a: int) (b: int) (c: int): int =
    (max (a + b + c) (a * b * c), max ((a + b) * c) (a * (b + c))) ||> max

// https://www.codewars.com/kata/56170e844da7c6f647000063
// Make a function that receive age, and return what they drink.
let peopleWithAgeDrink old =
    match old with
    | old when old < 14 -> "drink toddy"
    | old when old < 18 -> "drink coke"
    | old when old < 21 -> "drink beer"
    | _ -> "drink whisky"

// https://www.codewars.com/kata/57a059d753ba33229500001a
// Write function makeLowerCase.
let makeLowerCase (s: string) = s.ToLower()

// https://www.codewars.com/kata/57a083a57cb1f31db7000028
// Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n (inclusive).
let powersOfTwo n =
    [ for i in 0 .. n -> pown 2 i ]

// https://www.codewars.com/kata/57f6ad55cca6e045d2000627
// If the number has an integer square root, take this, otherwise square the number.
let squareOrSquareRoot (array: int []) =
    Array.map (fun x ->
        let root =
            x
            |> float
            |> sqrt
            |> int
        match x with
        | x when root * root = x -> root
        | _ -> x * x) array

// https://www.codewars.com/kata/57a1fd2ce298a731b20006a4
// Write function isPalindrome that checks if a given string (case insensitive) is a palindrome.
let isPalindrom (s: string) =
    let c = s.ToLower().ToCharArray()
    c = (c |> Array.rev)

// https://www.codewars.com/kata/57a5c31ce298a7e6b7000334
// Complete the function which converts a binary number (given as a string) to a decimal number.
let binToDec s = ("0b" + s) |> int

// https://www.codewars.com/kata/57f24e6a18e9fad8eb000296
// I love you, a little , a lot, passionately ... not at all
let howMuchILoveYou nbPetals =
    let petal = [| "not at all"; "I love you"; "a little"; "a lot"; "passionately"; "madly" |]
    petal.[nbPetals % 6]

// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e
// Write a function called repeatString which repeats the given String src exactly count times.
let repeatStr (n: int) (s: string) =
    [ for _ in 1 .. n -> s ]
    |> String.concat ""

// https://www.codewars.com/kata/50654ddff44f800200000004
// The code does not execute properly. Try to figure out why.
let multiply a b = a * b
