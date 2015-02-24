//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	output
//256	652

using System;
using System.Linq;

class ReverseNumber
{
	static void Main()
	{
		string task = "Problem 7. Reverse number\n\nWrite a method that reverses the digits of given decimal number.\nExample:\n\ninput	output\n256	652\n123.45	54.321\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter decimal number: ");

		decimal number = decimal.Parse(Console.ReadLine());

		decimal reversNumber = GetReversNumber(number);

		Console.WriteLine("Revers number: {0}", reversNumber);

	}

	private static decimal GetReversNumber(decimal number)
	{
		string reversNumberAsString = new string(number.ToString().Reverse().ToArray());

		return decimal.Parse(reversNumberAsString);
	}
}
