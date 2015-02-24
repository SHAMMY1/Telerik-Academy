//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	                    output
//aaaaabbbbbcdddeeeedssaa	abcdedsa

using System;

class SeriesOfLetters
{
	static void Main()
	{
		string task = "Problem 23. Series of letters\n\nWrite a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.\nExample:\n\ninput	                output\naaaaabbbbbcdddeeeedssaa	abcdedsa\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
