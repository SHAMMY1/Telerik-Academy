//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;

class ExtractEmail
{
	static void Main()
	{
		string task = "Problem 18. Extract e-mails\n\nWrite a program for extracting all email addresses from given text.\nAll sub-strings that match the format <identifier>@<host>…<domain> should be\nrecognized as emails.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
