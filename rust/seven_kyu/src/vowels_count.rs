// Vowel Count
// https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/rust

fn get_count(string: &str) -> usize {
    let mut vowels_count: usize = 0;

    let vowels = vec![ 'a', 'e', 'i', 'o', 'u'];

    for i in string.chars() {
        if vowels.contains(&i) {
            vowels_count += 1;
        }
    }

    vowels_count
}

#[test]
fn my_tests() {
    assert_eq!(get_count("abracadabra"), 5);
}