<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	var lastPalidrome = (from x in Enumerable.Range(100, 900)
						from y in Enumerable.Range(100, 900)
						let mult = x*y
						where mult.IsPalindrome()
						select mult).Max();
            
	lastPalidrome.Dump();
}

public static class NumberEx
{
	public static bool IsPalindrome(this int number)
	{
		string numberStr = number.ToString(CultureInfo.InvariantCulture);
		if(numberStr.Length % 2 != 0)
			return false;
		
		var reseveOrder = numberStr.Reverse();
		return reseveOrder.SequenceEqual(numberStr);
	}
}
