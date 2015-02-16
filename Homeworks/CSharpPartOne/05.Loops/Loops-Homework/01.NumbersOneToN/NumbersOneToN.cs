//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
//on a single line, separated by a space.
//Examples:

//n	   output
//3	   1 2 3
//5	   1 2 3 4 5

using System;
using System.Text;

class NumbersOneToN
{
	static void Main()
	{
		string task = "Problem 1. Numbers from 1 to N\n\nWrite a program that enters from the console a positive integer n and prints\nall the numbers from 1 to n, on a single line, separated by a space.\nExamples:\nn	output\n3	1 2 3\n5	1 2 3 4 5\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter number N: ");
		int numebrN = int.Parse(Console.ReadLine());

		StringBuilder Builder = new StringBuilder();

		for (int i = 1; i <= numebrN; i++)
		{
			Builder.Append(i);

			if (i != numebrN)
			{
				Builder.Append(' ');
			}
		}

		Console.WriteLine(Builder.ToString());
	}
}
