<Query Kind="Expression" />

Enumerable.Range(1,999)
	.Where(n => n % 3 == 0 || n % 5 == 0)
	.Sum()