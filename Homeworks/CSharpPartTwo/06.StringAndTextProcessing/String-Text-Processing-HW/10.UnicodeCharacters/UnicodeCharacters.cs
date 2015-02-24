//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	output
//Hi!	\u0048\u0069\u0021

using System;

class UnicodeCharacters
{
	static void Main()
	{
		string task = "Problem 10. Unicode characters\n\nWrite a program that converts a string to a sequence of C# Unicode character\nliterals.\nUse format strings.\nExample:\n\ninput	output\nHi!	\\u0048\\u0069\\u0021\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
