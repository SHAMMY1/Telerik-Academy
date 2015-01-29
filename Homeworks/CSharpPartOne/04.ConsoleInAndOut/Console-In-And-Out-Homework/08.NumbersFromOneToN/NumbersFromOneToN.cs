//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
//each on a single line.
//Note: You may need to use a for-loop.

//Examples:

//input	output
//3	    1
//      2
//      3

//5	    1
//      2
//      3
//      4
//      5

//1	    1

using System;

class NumbersFromOneToN
{
	static void Main()
	{
		string task = "Problem 8. Numbers from 1 to n\n\nWrite a program that reads an integer number n from the console and prints\nall the numbers in the interval [1..n], each on a single line.\nNote: You may need to use a for-loop.\nExamples:\ninput	output\n3	1\n	2\n        3\n\n5	1\n        2\n        3\n        4\n        5\n\n1	1\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter integer:");
		int numberN = int.Parse(Console.ReadLine());

		if (numberN > 1)
		{
			for (int i = 1; i <= numberN; i++)
			{
				Console.WriteLine(i);
			}
		}
		else
		{
			for (int i = 1; i >= numberN; i--)
			{
				Console.WriteLine(i);
			}
		}
	}
}
