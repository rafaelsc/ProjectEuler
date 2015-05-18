<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var limit = 100;

var sumOfSquares = 0;
for (int x = 1; x <= limit; x++)
{
	sumOfSquares += x*x;
}

var squaresOfSum = (limit+1) * (limit/2);
squaresOfSum *= squaresOfSum;

var diff = squaresOfSum - sumOfSquares;
diff.Dump();