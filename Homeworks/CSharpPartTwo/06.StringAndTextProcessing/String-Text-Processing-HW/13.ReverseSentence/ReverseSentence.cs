//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	                                    output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;

class ReverseSentence
{
	static void Main()
	{
		string task = "Problem 13. Reverse sentence\n\nWrite a program that reverses the words in given sentence.\nExample:\ninput\nC# is not C++, not PHP and not Delphi!\noutput\nDelphi not and PHP, not C++ not is C#!\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
