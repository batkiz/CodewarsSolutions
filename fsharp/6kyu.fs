module SixKyu

// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1
// Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string.
// The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.
let duplicateCount (text: string): int =
    let newText = String.map System.Char.ToLower text

    let pureT =
        newText
        |> Seq.toList
        |> List.distinct
    let countChar (where: string) (what: string) =
        match what with
        | "" -> 0
        | _ -> (where.Length - where.Replace(what, @"").Length) / what.Length

    let mutable count = 0
    for i in pureT do
        if (countChar newText (i |> string)) > 1 then count <- count + 1 else ()
    count
