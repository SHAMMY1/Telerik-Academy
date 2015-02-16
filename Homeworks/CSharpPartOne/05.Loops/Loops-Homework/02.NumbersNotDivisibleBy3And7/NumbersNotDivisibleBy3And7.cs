//Problem 2. Numbers Not Divisible by 3 and 7

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n
//not divisible by 3 and 7, on a single line, separated by a space.
//Examples:

//n	output
//3	1 2
//10	1 2 4 5 8 10

using System;
using System.Text;

class NumbersNotDivisibleBy3And7
{
	static void Main()
	{
		string task = "Problem 2. Numbers Not Divisible by 3 and 7\n\nWrite a program that enters from the console a positive integer n and prints\nall the numbers from 1 to n not divisible by 3 and 7, on a single line,\nseparated by a space.\nExamples:\nn	output\n3	1 2\n10	1 2 4 5 8 10\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter number N: ");
		int numebrN = int.Parse(Console.ReadLine());

		StringBuilder Builder = new StringBuilder();

		for (int i = 1; i <= numebrN; i++)
		{
			if ((i % 3 != 0) && (i % 7 != 0))
			{
				Builder.Append(i);

				if (i != numebrN)
				{
					Builder.Append(' ');
				}
			}
		}

		Console.WriteLine(Builder.ToString());
	}
}
