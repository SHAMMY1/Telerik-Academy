//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:

//a	    b	   greater
//5	    6	   6
//10	5	   10
//0	    0	   0
//-5	-2	   -2
//1.5	1.6	   1.6

using System;
using System.Linq;

class NumberComparer
{
	static void Main()
	{
		string task = "Problem 4. Number Comparer\n\nWrite a program that gets two numbers from the console\nand prints the greater of them.\nTry to implement this without if statements.\nExamples:\na	b	greater\n5	6	6\n10	5	10\n0	0	0\n-5	-2	-2\n1.5	1.6	1.6\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter two numbers(1,2):");
		string input = Console.ReadLine();

		double greaterNumber = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
			                        .Select(s => double.Parse(s))
									.Max();

		Console.WriteLine("Greater number: {0}", greaterNumber);
	}
}
