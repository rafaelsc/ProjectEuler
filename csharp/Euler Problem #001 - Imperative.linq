<Query Kind="Statements" />

int acc = 0;
for (int i = 0; i < 999; i++)
{
	if (i % 3 == 0 || i % 5 == 0)
	{
		acc += i;
	}
}
acc.Dump();