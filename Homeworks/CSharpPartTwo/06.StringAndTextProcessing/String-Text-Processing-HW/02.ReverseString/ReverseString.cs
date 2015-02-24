//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	    output
//sample	elpmas

using System;

class ReverseString
{
	static void Main()
	{
		string task = "Problem 2. Reverse string\n\nWrite a program that reads a string, reverses it and prints the result at the\nconsole.\nExample:\n\ninput	output\nsample	elpmas\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
