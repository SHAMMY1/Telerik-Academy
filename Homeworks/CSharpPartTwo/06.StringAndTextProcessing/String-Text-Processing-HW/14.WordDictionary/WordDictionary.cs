//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	      output
//.NET	      platform for applications from Microsoft
//CLR	      managed execution environment for .NET
//namespace	  hierarchical organization of classes

using System;

class WordDictionary
{
	static void Main()
	{
		string task = "Problem 14. Word dictionary\n\nA dictionary is stored as a sequence of text lines containing words and their\nexplanations.\nWrite a program that enters a word and translates it by using the dictionary.\nSample dictionary:\ninput	        output\n.NET	        platform for applications from Microsoft\nCLR	        managed execution environment for .NET\nnamespace	hierarchical organization of classes\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
