//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.
//Examples:

//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false
using System;

class OddOrEvenIntegers
{
	static void Main()
	{
		string task = "Problem 1. Odd or Even Integers\n\nWrite an expression that checks if given integer is odd or even.\n\nExamples:\nn	Odd?\n3	true\n2	false\n-2	false\n-1	true\n0	false\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.WriteLine("Enter number:");

		int number = int.Parse(Console.ReadLine());

		bool isOdd = true;

		if (number % 2 == 0)
		{
			isOdd = false;
		}

		Console.WriteLine();
		Console.WriteLine("Number {0} is {1}! ({2})", number, isOdd ? "odd" : "even", isOdd);

	}
}