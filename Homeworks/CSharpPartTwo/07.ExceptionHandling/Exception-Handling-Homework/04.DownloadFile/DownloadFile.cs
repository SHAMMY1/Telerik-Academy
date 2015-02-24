//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image,http://telerikacademy.com/Content/Images/news-img01.png)
//and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;

class DownloadFile
{
	static void Main()
	{
		string task = "Problem 4. Download file\n\nWrite a program that downloads a file from Internet (e.g. Ninja image)\nand stores it the current directory.\nFind in Google how to download files in C#.\nBe sure to catch all exceptions and to free any used resources in the finally\nblock.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
