//Problem 4. Unicode Character

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
//using the \u00XX syntax, and then print it.

using System;

class UnicodeCharacter
{
	static void Main()
	{
		string task = "Problem 4. Unicode Character\n\nDeclare a character variable and assign it with the symbol that has Unicode\ncode 42 (decimal) using the \\u00XX syntax, and then print it.\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		char character = '\u002A';

		Console.WriteLine("Character with unicode 42 (\\u002A): {0}",character);

	}
}
