//Problem 11. Format number

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

class FormatNumber
{
	static void Main()
	{
		string task = "Problem 11. Format number\n\nWrite a program that reads a number and prints it as a decimal number,\nhexadecimal number, percentage and in scientific notation.\nFormat the output aligned right in 15 symbols.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

	}
}
