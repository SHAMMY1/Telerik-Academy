//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest>
//<interest>C#</interest><interest>Java</interest></interests></student>

using System;

class ExtractTextFromXML
{
	static void Main()
	{
		string task = "Problem 10. Extract text from XML\n\nWrite a program that extracts from given XML file all the text without the tags.\nExample:\n\n<?xml version=\"1.0\"><student><name>Pesho</name><age>21</age>\n<interests count=\"3\"><interest>Games</interest><interest>C#</interest>\n<interest>Java</interest></interests></student>\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
