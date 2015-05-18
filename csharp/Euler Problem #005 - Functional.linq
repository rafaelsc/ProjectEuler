<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	var divs = Enumerable.Range(1, 20);
	var firstNumber = (from x in Enumerable.Range(1, int.MaxValue)
						where divs.All(d=> x % d == 0)
						select x).First();
	firstNumber.Dump();
}
