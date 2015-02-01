//Problem 12.* Zero Subset

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:

//numbers	          result
//3 -2 1 1 8	     -2 + 1 + 1 = 0
				     
//3 1 -7 35 22	     no zero subset
				     
//1 3 -4 -2 -1	     1 + -1 = 0
//                   1 + 3 + -4 = 0
//                   3 + -2 + -1 = 0
				     
//1 1 1 -1 -1	     1 + -1 = 0
//                   1 + 1 + -1 + -1 = 0
				     
//0 0 0 0 0	         0 + 0 + 0 + 0 + 0 = 0

//Hint: you may check for zero each of the 31 subsets with 31 if statements.

using System;
using System.Linq;

class ZeroSubset
{
	static void Main()
	{
		string task = "Problem 12.* Zero Subset\n\nWe are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.\nAssume that repeating the same subset several times is not a problem.\nExamples:\nnumbers	result\n3 -2 1 1 8	-2 + 1 + 1 = 0\n\n3 1 -7 35 22	no zero subset\n\n1 3 -4 -2 -1	1 + -1 = 0\n                1 + 3 + -4 = 0\n                3 + -2 + -1 = 0\n\n1 1 1 -1 -1	1 + -1 = 0\n                1 + 1 + -1 + -1 = 0\n\n0 0 0 0 0	0 + 0 + 0 + 0 + 0 = 0\n\nHint: you may check for zero each of the 31 subsets with 31 if statements.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter five number(1, 2,3,4,5):");
		string input = Console.ReadLine();

		char[] separators = { ' ', ',' };

		var numbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

		bool hasZeroSubsets = false;
		
		for (int i = 1; i < Math.Pow(2,numbers.Length); i++)
		{
			int sum = 0;
			string subset = "";
			for (int j = 0; j < numbers.Length; j++)
			{
				if ((i & (1 << j)) != 0)
				{
					sum += numbers[j];

					subset += numbers[j] + " + ";
				}
			}

			if (sum == 0)
			{
				Console.WriteLine(subset.TrimEnd().TrimEnd('+') + " = 0");
				hasZeroSubsets = true;
			}
		}

		if (!hasZeroSubsets)
		{
			Console.WriteLine("no zero subset");
		}



	}
}
