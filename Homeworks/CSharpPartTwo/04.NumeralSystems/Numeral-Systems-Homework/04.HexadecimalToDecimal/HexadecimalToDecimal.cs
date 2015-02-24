//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
	static void Main()
	{
		string task = "Problem 4. Hexadecimal to decimal\n\nWrite a program to convert hexadecimal numbers to their decimal representation.\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter hexadecimal number(64bit long if negative): ");
		string number = Console.ReadLine().Trim();

		Console.WriteLine("\nDecimal representation: {0}", ConvertHexadecimalToDecimal(number));
	}

	private static long ConvertHexadecimalToDecimal(string hexadecimalNumber)
	{
		hexadecimalNumber = hexadecimalNumber.TrimStart(new[] { '0', 'x' }).ToUpper();

		long result = 0;

		char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

		for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
		{
			int number = Array.IndexOf(digits, hexadecimalNumber[i]);
			int pow = hexadecimalNumber.Length - 1 - i;
			result += number * (long)Math.Pow(16, pow);
		}

		return result;
	}
}
