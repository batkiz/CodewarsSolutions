package kata

func Race(v1, v2, g int) [3]int {
	if v1 >= v2 {
		return [3]int{-1, -1, -1}
	}

	time := float64(g) * 3600 / float64(v2-v1)
	totalSecs := int(time)

	hours := totalSecs / 3600
	mins := (totalSecs - hours*3600) / 60
	secs := totalSecs % 60

	return [3]int{hours, mins, secs}
}
