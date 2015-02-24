//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight.
//So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;

class ExtractSentences
{
	static void Main()
	{
		string task = "Problem 8. Extract sentences\n\nWrite a program that extracts from a given text all sentences containing given\nword.\nExample:\n\nThe word is: in\n\nThe text is\nWe are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.\n\nThe expected result is:\nWe are living in a yellow submarine. We will move out of it in 5 days.\n\nConsider that the sentences are separated by .\nand the words – by non-letter symbols.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
