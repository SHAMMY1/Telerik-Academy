//Problem 13. Count words

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words
//is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their
//occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;

class CountWords
{
	static void Main()
	{
		string task = "Problem 13. Count words\n\nWrite a program that reads a list of words from the file words.txt and finds\nhow many times each of the words is contained in another file test.txt.\nThe result should be written in the file result.txt and the words should be\nsorted by the number of their occurrences in descending order.\nHandle all possible exceptions in your methods.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
