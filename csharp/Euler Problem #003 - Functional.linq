<Query Kind="Program" />

void Main()
{
	//var factors = 13195L.Factorizate();
	var factors = 600851475143
					.Factorizate()
					.Max();
	
	factors.Dump();
}

public static class NumberEx
{
	public static IEnumerable<long> Factorizate(this long number)
	{
		var primeLimit = (long) Math.Sqrt(number);
		foreach (var prime in Sequence.Primes(primeLimit))
		{
			if(number % prime == 0)
				yield return prime;
		}
	}
	
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