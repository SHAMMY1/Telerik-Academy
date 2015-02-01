//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:

//a	     b	    c	   d	 e	     biggest
//5	     2	    2	   4	 1	     5
//-2	-22	    1	   0	 0	     1
//-2	 4	    3	   2	 0	     4
//0	    -2.5	0	   5	 5	     5
//-3	-0.5   -1.1	  -2	-0.1	-0.1

using System;
using System.Linq;

class BiggestOfFiveNumbers
{
	static void Main()
	{
		string task = "Problem 6. The Biggest of Five Numbers\n\nWrite a program that finds the biggest of five numbers by using only five if statements.\nExamples:\na	b	c	d	e	biggest\n5	2	2	4	1	5\n-2	-22	1	0	0	1\n-2	4	3	2	0	4\n0	-2.5	0	5	5	5\n-3	-0.5	-1.1	-2	-0.1	-0.1\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter five number(1, 2,3,4,5):");
		string input = Console.ReadLine();

		char[] separators = { ' ', ',' };

		var numbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(s => double.Parse(s)).ToArray();

		double biggestNumber = numbers[0];

		for (int i = 1; i < numbers.Length; i++)
		{
			if (biggestNumber < numbers[i])
			{
				biggestNumber = numbers[i];
			}
		}

		Console.WriteLine("Biggest number: {0}",biggestNumber);
	}
}
