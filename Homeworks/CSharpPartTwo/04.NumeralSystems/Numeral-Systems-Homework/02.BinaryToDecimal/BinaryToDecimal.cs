//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Linq;

class BinaryToDecimal
{
	static void Main()
	{
		string task = "Problem 2. Binary to decimal\n\nWrite a program to convert binary numbers to their decimal representation.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter binary number(64bit long if negative): ");
		string binaryNumber = Console.ReadLine().Trim();

		Console.WriteLine("Decimal representation: {0}", ConvertBinaryToDecimal(binaryNumber));
	}

	private static long ConvertBinaryToDecimal(string binaryNumber)
	{
		binaryNumber = binaryNumber.TrimStart('0');

		long result = 0;

		for (int i = binaryNumber.Length - 1; i >= 0; i--)
		{
			int number = binaryNumber[i] - '0';
			int pow = binaryNumber.Length - 1 - i;
			result += number * (long)Math.Pow(2, pow);
		}

		return result;
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
