//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;

class PrefixTest
{
	static void Main()
	{
		string task = "Problem 11. Prefix \"test\"\n\nWrite a program that deletes from a text file all words that start with the\nprefix test.\nWords contain only the symbols 0…9, a…z, A…Z, _.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
