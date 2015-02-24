//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;
using System.Linq;

class DecimalToBinary
{
	static void Main()
	{
		string task = "Problem 1. Decimal to binary\n\nWrite a program to convert decimal numbers to their binary representation.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter decimal number: ");
		long number = long.Parse(Console.ReadLine());
		Console.WriteLine("\nBinary representation:\n{0}", ConvertDecimalToBinary(number));

		Console.WriteLine(Convert.ToString(number, 2));
	}

	private static string ConvertDecimalToBinary(long decimalNumber)
	{
		bool isNegative = decimalNumber < 0;

		decimalNumber = decimalNumber < 0 ? -decimalNumber: decimalNumber;

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
		var NegativeResultString = numberToRevers.TrimStart('-').PadLeft(64, '0').Select(s => s == '1' ? '0' : '1').ToArray();

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
