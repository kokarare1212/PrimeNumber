package main

import (
	"fmt"
	"math"
)

func main()  {
	for i:=2; i < 10000000; i++{
		k := math.Sqrt(float64(i))
		f := true
		for j:=2; float64(j) <= k; j++{
			if (i % j) == 0{
				f = false
				break
			}
		}
		if f{
			fmt.Println(i)
		}
	}
}
