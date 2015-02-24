//Problem 6. binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class BinaryToHexadecimal
{
	static void Main()
	{
		string task = "Problem 6. binary to hexadecimal\n\nWrite a program to convert binary numbers to hexadecimal numbers (directly).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter binary number: ");
		string number = Console.ReadLine().Trim();

		Console.WriteLine("\nHexadecimal representation: {0}",ConvertBinaryToHexadecimal(Convert.ToString(long.MinValue,2)));
		Console.WriteLine(Convert.ToString(long.MinValue, 16));

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

		for (int i = 0; i < binaryNumber.Length; i+=4)
		{
			result.Append(digits[binaryNumber.Substring(i, 4)]);
		}

		return result.ToString().TrimStart('0');
	}
}
