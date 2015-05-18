<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var limit = 100;

var sumOfSquares = (from x in Enumerable.Range(1, limit)
					select x*x).Sum();
var squaresOfSum = Math.Pow(Enumerable.Range(1, limit).Sum(),2);
	
var diff = squaresOfSum - sumOfSquares;
diff.Dump();