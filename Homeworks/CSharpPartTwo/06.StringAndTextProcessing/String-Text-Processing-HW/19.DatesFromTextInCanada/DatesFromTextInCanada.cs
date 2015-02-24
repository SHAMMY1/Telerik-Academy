//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;

class DatesFromTextInCanada
{
	static void Main(string[] args)
	{
		string task = "Problem 19. Dates from text in Canada\n\nWrite a program that extracts from a given text all dates that match the format\nDD.MM.YYYY.\nDisplay them in the standard date format for Canada.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
