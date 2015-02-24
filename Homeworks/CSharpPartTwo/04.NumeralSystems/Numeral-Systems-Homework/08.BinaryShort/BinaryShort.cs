//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Text;
using System.Linq;

class BinaryShort
{
	static void Main()
	{
		string task = "Problem 8. Binary short\n\nWrite a program that shows the binary representation of given 16-bit signed\ninteger number (the C# type short).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter decimal number(16bit short): ");
		short number = short.Parse(Console.ReadLine());
		Console.WriteLine("\nBinary representation:\n{0}", ConvertDecimalToBinary(number));

		Console.WriteLine(Convert.ToString(number, 2));
	}

	private static string ConvertDecimalToBinary(short decimalNumber)
	{
		bool isNegative = decimalNumber < 0;

		decimalNumber = decimalNumber < 0 ? (short)-decimalNumber : decimalNumber;

		StringBuilder result = new StringBuilder();

		do
		{
			result.Insert(0, decimalNumber % 2);
			decimalNumber /= 2;

		} while (decimalNumber != 0);

		string resultString = result.ToString();

		if (isNegative)
		{
			resultString = ReversBits(resultString);

		}

		return resultString;
	}

	private static string ReversBits(string numberToRevers)
	{
		var NegativeResultString = numberToRevers.TrimStart('-').PadLeft(16, '0').Select(s => s == '1' ? '0' : '1').ToArray();

		int index = NegativeResultString.Length;

		do
		{
			index--;
			NegativeResultString[index] = NegativeResultString[index] == '1' ? '0' : '1';

		} while (NegativeResultString[index] == '0');

		numberToRevers = new string(NegativeResultString);
		return numberToRevers;
	}
}
