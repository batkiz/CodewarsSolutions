// Find the divisors!
// https://www.codewars.com/kata/544aed4c4a30184e960010f4/train/rust

use std::prelude::v1::ToString;

fn divisors(integer: u32) -> Result<Vec<u32>, String> {
    let mut v: Vec<u32> = Vec::new();

    for i in 2..(integer / 2 + 1) {
        if integer % i == 0 {
            v.push(i);
        }
    }

    if v.is_empty() {
        let str = format!("{} is prime", integer);
        return Err(str);
    }

    Ok(v)
}

#[test]
fn tests() {
    assert_eq!(divisors(15), Ok(vec![3, 5]));
    assert_eq!(divisors(12), Ok(vec![2, 3, 4, 6]));
    assert_eq!(divisors(13), Err("13 is prime".to_string()));
}
