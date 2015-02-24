//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;

class LineNumbers
{
	static void Main()
	{
		string task = "Problem 3. Line numbers\n\nWrite a program that reads a text file and inserts line numbers in front of\neach of its lines.\nThe result should be written to another text file.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
