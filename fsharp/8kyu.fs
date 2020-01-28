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
    let bmi:float = (weight/(height*height))
    match bmi with
    | bmi when bmi <= 18.5 -> "Underweight"
    | bmi when bmi <= 25.0 -> "Normal"
    | bmi when bmi <= 30.0 -> "Overweight"
    | _ -> "Obese"

// https://www.codewars.com/kata/5ae62fcf252e66d44d00008e
// Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ().
let expressionMatter (a: int) (b: int) (c: int): int =
    (max (a+b+c) (a*b*c), max ((a+b)*c) (a*(b+c))) ||> max
