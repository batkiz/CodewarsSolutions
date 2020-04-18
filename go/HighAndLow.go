package kata

import (
	"fmt"
	"strconv"
	"strings"
)

func HighAndLow(in string) string {
	nums := strings.Split(in, " ")

	high, _ := strconv.Atoi(nums[0])
	low, _ := strconv.Atoi(nums[0])

	for _, num := range nums {
		i, _ := strconv.Atoi(num)
		if i > high {
			high = i
		}
		if i < low {
			low = i
		}
	}

	return fmt.Sprintf("%v %v", high, low)
}
