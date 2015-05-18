<Query Kind="Statements" />

const int maxValue = 1000;
const int sumValue = maxValue;

int a, b, c;

for(a = 0; a < maxValue; a++)
for(b = a+1; b < maxValue; b++)
for(c = b+1; c < maxValue; c++)
{
	if(a < b && b < c && (a + b + c == sumValue) && (a*a + b*b == c*c))
	{
		a.Dump("A");
		b.Dump("B");
		c.Dump("C");
		(a*b*c).Dump("Product");
		return;
	}
}
