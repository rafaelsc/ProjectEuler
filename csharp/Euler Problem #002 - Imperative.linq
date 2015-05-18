<Query Kind="Statements" />

int acc = 0;

int n1 = 0;
int n2 = 1;
do
{
	if(n1 % 2 == 0)
	{
		acc += n1;
	}
	int n3 = n1 + n2;
	n1 = n2;
	n2 = n3;
}
while(n1 < 4000000); 

acc.Dump();
