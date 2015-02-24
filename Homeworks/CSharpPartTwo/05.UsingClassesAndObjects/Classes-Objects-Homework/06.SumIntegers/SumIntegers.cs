//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:

//input	            output
//"43 68 9 23 318"	461

using System;

class SumIntegers
{
	static void Main()
	{
		string task = "Problem 6. Sum integers\n\nYou are given a sequence of positive integer values written into a string, separated by spaces.\nWrite a function that reads these values from given string and calculates their sum.\nExample:\n\ninput	                output\n\"43 68 9 23 318\"	461\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
