<Query Kind="Program" />

void Main()
{
	var primes = Sequence.Primes().TakeWhile(n => n < 2000000).Sum();
	
	primes.Dump();
}

public static class NumberEx
{
	public static bool IsPrime(this long number)
	{
		if (number == 1) return false;
		if (number == 2) return true;
	
		for (int i = 2; (i*i) <= number; ++i)  
		{
			if (number % i == 0)  
				return false;
		}
	
		return true;
	}
}
public static class Sequence
{
	public static IEnumerable<long> Primes(long limit = Int64.MaxValue)
	{
		for(long x = 1; x < limit; x++)
		{
			if(x.IsPrime())
			{
				yield return x;
			}
		}
	}
}