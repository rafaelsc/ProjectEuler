<Query Kind="Program" />

void Main()
{
	var sum = Sequence.Fibonacci(4000000)
				.FilterEven()
				.Sum();
	
	sum.Dump();
}

public static class Sequence
{
	public static IEnumerable<int> Fibonacci(int limit = Int32.MaxValue)
	{
		int n1 = 0;
		int n2 = 1;
		
		yield return n1;
		yield return n2;
		
		do
		{
			int n3 = n1 + n2;
			n1 = n2;
			n2 = n3;
			yield return n3;
		}
		while(n1 < limit); 
	}
}

public static class NumberEx
{
	public static IEnumerable<int> FilterEven(this IEnumerable<int> seq)
	{
		return seq.Where(n => IsEven(n));
	}

	public static bool IsEven(this int number)
	{
		return number % 2 == 0; //TODO: Pode melhorar o desemepnho. Usando XOR.
	}
}