//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
	static char[] arrayOfLetters;
	static string word;

	static void Main(string[] args)
	{
		string task = "Problem 12. Index of letters\n\nWrite a program that creates an array containing all letters from the\nalphabet (A-Z).Read a word from the console and print the index of each of\nits letters in the array.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		InitializingArrayOfLeters();

		ReadAndFormatWord();

		FindAndPrintResult();
	}

	private static void InitializingArrayOfLeters()
	{
		arrayOfLetters = new char[26];

		for (int i = 0; i < arrayOfLetters.Length; i++)
		{
			arrayOfLetters[i] = Convert.ToChar(i + 65);
		}
	}

	private static void FindAndPrintResult()
	{
		for (int i = 0; i < word.Length; i++)
		{
			for (int j = 0; j < arrayOfLetters.Length; j++)
			{
				if (word[i] == arrayOfLetters[j])
				{
					Console.WriteLine("{0} on ibdex {1}", word[i], j);
					break;
				}
			}
		}

	}

	private static void ReadAndFormatWord()
	{
		Console.WriteLine("Enter word(WORD):");

		word = Console.ReadLine();

		word = word.ToUpper();
	}
}
