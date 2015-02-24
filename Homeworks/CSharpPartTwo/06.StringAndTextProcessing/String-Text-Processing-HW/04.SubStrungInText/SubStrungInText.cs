//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows:
//We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

using System;

class SubStrungInText
{
	static void Main()
	{
		string task = "Problem 4. Sub-string in text\n\nWrite a program that finds how many times a sub-string is contained in a given\ntext (perform case insensitive search).\nExample:\nThe target sub-string is in\n\nThe text is as follows: We are living in an yellow submarine. \nWe don't have anything else. inside the submarine is very tight. So we are\ndrinking all the day. We will move out of it in 5 days.\n\nThe result is: 9\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
