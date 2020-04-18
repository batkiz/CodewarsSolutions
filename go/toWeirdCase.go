package kata

import (
	"strings"
	"unicode"
)

func toWeirdCase(str string) string {
	var newStr strings.Builder
	n := 0

	for i, v := range str {
		if unicode.IsSpace(v) {
			newStr.WriteByte(byte(v))
			if i%2 == 0 {
				n = 1
			} else {
				n = 0
			}
		} else {
			if i%2 == n {
				newStr.WriteByte(byte(unicode.ToUpper(v)))
			} else {
				newStr.WriteByte(byte(unicode.ToLower(v)))
			}
		}
	}

	return newStr.String()
}
