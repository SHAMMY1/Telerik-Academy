//Problem 25. Extract text from HTML

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//	Academy</a>aims to provide free real-world practical
//	training for young people who want to turn into
//	skilful .NET software engineers.</p></body>
//</html>
//Output:

//Title: News

//Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET
//software engineers.

using System;

class ExtractTextFromHTML
{
	static void Main()
	{
		string task = "Problem 25. Extract text from HTML\n\nWrite a program that extracts from given HTML file its title (if available),\nand its body text without the HTML tags.\nExample input:\n\n<html>\n  <head><title>News</title></head>\n  <body><p><a href=\"http://academy.telerik.com\">Telerik\n    Academy</a>aims to provide free real-world practical\n    training for young people who want to turn into\n    skilful .NET software engineers.</p></body>\n</html>\n\nOutput:\n\nTitle: News\n\nText: Telerik Academy aims to provide free real-world practical training for\nyoung people who want to turn into skilful .NET software engineers.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
