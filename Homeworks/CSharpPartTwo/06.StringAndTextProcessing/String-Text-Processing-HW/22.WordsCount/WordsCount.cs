//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words in the string
//along with information how many times each word is found.

using System;

class WordsCount
{
	static void Main()
	{
		string task = "Problem 22. Words count\n\nWrite a program that reads a string from the console and lists all different\nwords in the string along with information how many times each word is found.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
