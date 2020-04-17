package kata

func Multiple3And5(number int) int {
	sum := 0

	for num := 0; num < number; num++ {
		if num%3 == 0 || num%5 == 0 {
			sum += num
		}
	}

	return sum
} 