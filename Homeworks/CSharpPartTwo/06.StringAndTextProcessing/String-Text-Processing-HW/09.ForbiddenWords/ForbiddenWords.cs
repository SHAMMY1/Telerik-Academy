//Problem 9. Forbidden words

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is
//implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is
//implemented as a dynamic language in ***.

using System;

class ForbiddenWords
{
	static void Main()
	{
		string task = "Problem 9. Forbidden words\n\nWe are given a string containing a list of forbidden words and a text\ncontaining some of these words.\nWrite a program that replaces the forbidden words with asterisks.\nExample text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.\n\nForbidden words: PHP, CLR, Microsoft\nThe expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
