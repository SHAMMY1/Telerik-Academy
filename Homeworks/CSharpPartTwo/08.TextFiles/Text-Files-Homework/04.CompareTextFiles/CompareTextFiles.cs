//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and
//the number of lines that are different.
//Assume the files have equal number of lines.

using System;

class CompareTextFiles
{
	static void Main(string[] args)
	{
		string task = "Problem 4. Compare text files\n\nWrite a program that compares two text files line by line and prints the number\nof lines that are the same and the number of lines that are different.\nAssume the files have equal number of lines.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
