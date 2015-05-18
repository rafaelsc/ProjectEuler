<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	var lastPalidrome = 0;
	for(int x = 99; x < 1000 ; x++)
	{
		for(int y = 99; y < 1000 ; y++)
		{
			var number = x*y;
			if(number.IsPalindrome())
			{
				lastPalidrome = Math.Max(number, lastPalidrome);
				break;
			}
		}
	}
	
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