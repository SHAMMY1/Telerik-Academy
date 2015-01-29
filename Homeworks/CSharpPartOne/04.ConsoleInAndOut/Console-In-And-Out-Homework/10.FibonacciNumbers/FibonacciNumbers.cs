//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;
using System.Text;

class FibonacciNumbers
{
	static void Main()
	{
		string task = "Problem 10. Fibonacci Numbers\n\nWrite a program that reads a number n and prints on the console the first\nn members of the Fibonacci sequence (at a single line, separated by\ncomma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….\nNote: You may need to learn how to use loops.\nExamples:\nn	comments\n1	0\n3	0 1 1\n10	0 1 1 2 3 5 8 13 21 34\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number N: ");
		long numberN = long.Parse(Console.ReadLine());
		if (numberN < 1)
		{
			Console.WriteLine("INVALID INPUT\nNumber n must be greater than 0!!!");
		}
		else
		{
			long first = 0;
			long second = 1;

			StringBuilder Builder = new StringBuilder();
			Builder.AppendFormat(numberN == 1 ? "0" : "{0}, {1}", first, second);

			for (int i = 0; i < numberN - 2; i++)
			{
				long tempNumber = first + second;

				if (tempNumber < second)
				{
					Builder.AppendLine(", . . .");
					break;
				}

				first = second;
				second = tempNumber;

				Builder.AppendFormat(", {0}", tempNumber);
			}

			Console.WriteLine(Builder);
		}
	}
}
