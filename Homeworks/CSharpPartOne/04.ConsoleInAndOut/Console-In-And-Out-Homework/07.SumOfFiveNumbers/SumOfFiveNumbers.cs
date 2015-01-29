//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers	           sum
//1 2 3 4 5	           15
//10 10 10 10 10	   50
//1.5 3.14 8.2 -1 0	   11.84

using System;
using System.Linq;

class SumOfFiveNumbers
{
	static void Main()
	{
		string task = "Problem 7. Sum of 5 Numbers\n\nWrite a program that enters 5 numbers (given in a single line,\nseparated by a space), calculates and prints their sum.\nExamples:\nnumbers	            sum\n1 2 3 4 5           15\n10 10 10 10 10      50\n1.5 3.14 8.2 -1 0   11.84\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter five numbers separated by a space(1 2 3 4 5):");
		string input = Console.ReadLine();

		double sum = input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
			              .Select(s => double.Parse(s))
						  .Sum();

		Console.WriteLine("SUm = {0}", sum);
	}
}
