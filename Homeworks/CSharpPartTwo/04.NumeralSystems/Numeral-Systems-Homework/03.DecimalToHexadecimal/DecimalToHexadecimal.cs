//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class DecimalToHexadecimal
{
	static void Main()
	{
		string task = "Problem 3. Decimal to hexadecimal\n\nWrite a program to convert decimal numbers to their hexadecimal representation.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter decimal number: ");
		long number = long.Parse(Console.ReadLine());


		Console.WriteLine("\nHexadecimal representation:\n{0}", ConvertDecimalToHexadecimal(number));
		//Check the result
		Console.WriteLine(Convert.ToString(number, 16));
	}

	private static string ConvertDecimalToHexadecimal(long decimalNumber)
	{
		if (decimalNumber >= 0)
		{

			StringBuilder result = new StringBuilder();

			char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

			do
			{
				result.Insert(0, digits[decimalNumber % 16]);
				decimalNumber /= 16;
			} while (decimalNumber != 0);


			return result.ToString();
		}
		else
		{
			return ConvertBinaryToHexadecimal(ConvertDecimalToBinary(decimalNumber));
		}
	}

	private static string ConvertDecimalToBinary(long decimalNumber)
	{
		bool isNegative = decimalNumber < 0;

		decimalNumber = decimalNumber < 0 ? -decimalNumber : decimalNumber;

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

	private static string ConvertBinaryToHexadecimal(string binaryNumber)
	{
		Dictionary<string, string> digits = new Dictionary<string, string>();
		digits.Add("0000", "0");
		digits.Add("0001", "1");
		digits.Add("0010", "2");
		digits.Add("0011", "3");
		digits.Add("0100", "4");
		digits.Add("0101", "5");
		digits.Add("0110", "6");
		digits.Add("0111", "7");
		digits.Add("1000", "8");
		digits.Add("1001", "9");
		digits.Add("1010", "A");
		digits.Add("1011", "B");
		digits.Add("1100", "C");
		digits.Add("1101", "D");
		digits.Add("1111", "F");

		binaryNumber = binaryNumber.PadLeft(64, '0');

		StringBuilder result = new StringBuilder();

		for (int i = 0; i < binaryNumber.Length; i += 4)
		{
			result.Append(digits[binaryNumber.Substring(i, 4)]);
		}

		return result.ToString().TrimStart('0');
	}
}
