//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;

class ReplaceSubString
{
	static void Main()
	{
		string task = "Problem 7. Replace sub-string\n\nWrite a program that replaces all occurrences of the sub-string start with\nthe sub-string finish in a text file.\nEnsure it will work with large files (e.g. 100 MB).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
