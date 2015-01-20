//Problem 14.* Print the ASCII Table

//Find online more information about ASCII (American Standard Code for Information Interchange) and write 
//a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them 
//or display them differently.

//Note: You may need to use for-loops (learn in Internet how).

using System;
using System.Text;

class PrintTheASCIITable
{
	static void Main()
	{
		string task = "Problem 14.* Print the ASCII Table\n\nFind online more information about ASCII\n(American Standard Code for Information Interchange)\nand write a program that prints the entire ASCII table of characters\non the console (characters from 0 to 255).\n";
		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		string title = "ANSCII TABLE";
		Console.WriteLine(title.PadLeft(16));
		Console.Write("Code".PadLeft(7));
		Console.Write("character".PadLeft(13));
		Console.WriteLine();

		Console.OutputEncoding = Encoding.ASCII;

		for (int i = 0; i < 256; i++)
		{
			Console.Write(i.ToString().PadLeft(7));
			char character = (char)i;
			Console.WriteLine(character.ToString().PadLeft(11));
		}
	}
}
