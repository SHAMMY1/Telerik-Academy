//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
//the rest of the characters should be filled with *.
//Print the result string into the console.

using System;

class StringLength
{
	static void Main()
	{
		string task = "Problem 6. String length\n\nWrite a program that reads from the console a string of maximum 20 characters.\nIf the length of the string is less than 20, the rest of the characters should \nbe filled with *.\nPrint the result string into the console.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
