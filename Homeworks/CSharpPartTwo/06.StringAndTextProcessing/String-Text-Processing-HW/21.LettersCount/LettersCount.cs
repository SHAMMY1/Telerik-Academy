//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in the string along with information
//how many times each letter is found.

using System;

class LettersCount
{
	static void Main()
	{
		string task = "Problem 21. Letters count\n\nWrite a program that reads a string from the console and prints all different\nletters in the string along with information how many times each letter is\nfound.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
