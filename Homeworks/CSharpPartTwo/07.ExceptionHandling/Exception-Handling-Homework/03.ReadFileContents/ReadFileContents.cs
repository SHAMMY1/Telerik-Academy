//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;

class ReadFileContents
{
	static void Main()
	{
		string task = "Problem 3. Read file contents\n\nWrite a program that enters file name along with its full file path\n(e.g. C:\\WINDOWS\\win.ini), reads its contents and prints it on the console.\nFind in MSDN how to use System.IO.File.ReadAllText(…).\nBe sure to catch all possible exceptions and print user-friendly error messages.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
