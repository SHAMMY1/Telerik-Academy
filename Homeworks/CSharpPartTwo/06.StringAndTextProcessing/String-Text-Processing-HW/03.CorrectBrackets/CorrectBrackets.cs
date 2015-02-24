//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
	static void Main(string[] args)
	{
		string task = "Problem 3. Correct brackets\n\nWrite a program to check if in a given expression the brackets are put\ncorrectly.\nExample of correct expression: ((a+b)/5-d).\nExample of incorrect expression: )(a+b)).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
