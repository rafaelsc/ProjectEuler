<Query Kind="Program" />

void Main()
{
	var sum = Enumerable.Range(1,999)
				.FilterMultipleOfThreeOrFive()
				.Sum();
	
	sum.Dump();
}

public static class NumberEx
{
	public static IEnumerable<int> FilterMultipleOfThreeOrFive(this IEnumerable<int> seq)
	{
		return seq.Where(n => IsMultipleOfThreeOrFive(n));
	}

	public static bool IsMultipleOfThreeOrFive(this int number)
	{
		return number % 3 == 0 || number % 5 == 0;
	}


}