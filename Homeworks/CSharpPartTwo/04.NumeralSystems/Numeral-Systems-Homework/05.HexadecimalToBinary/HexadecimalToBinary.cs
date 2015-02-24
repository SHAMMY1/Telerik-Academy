//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class HexadecimalToBinary
{
	static void Main()
	{
		string task = "Problem 5. Hexadecimal to binary\n\nWrite a program to convert hexadecimal numbers to binary numbers (directly).\n";

		string separator = new string('*', Console.WindowWidth);

		Console.WriteLine(task);
		Console.WriteLine(separator);

		Console.Write("Enter hexadecimal number: ");
		string number = Console.ReadLine().Trim();

		Console.WriteLine("Binary representation: {0}", ConvertHexadecimalToBinary(number));
	}

	private static string ConvertHexadecimalToBinary(string HexadecimalNumber)
	{
		Dictionary<char, string> digits = new Dictionary<char, string>();
		digits.Add('0', "0000");
		digits.Add('1', "0001");
		digits.Add('2', "0010");
		digits.Add('3', "0011");
		digits.Add('4', "0100");
		digits.Add('5', "0101");
		digits.Add('6', "0110");
		digits.Add('7', "0111");
		digits.Add('8', "1000");
		digits.Add('9', "1001");
		digits.Add('A', "1010");
		digits.Add('B', "1011");
		digits.Add('C', "1100");
		digits.Add('D', "1101");
		digits.Add('E', "1110");
		digits.Add('F', "1111");

		HexadecimalNumber = HexadecimalNumber.TrimStart(new[] { '0', 'x' }).ToUpper();

		StringBuilder result = new StringBuilder();

		for (int i = 0; i < HexadecimalNumber.Length; i++)
		{
			result.Append(digits[HexadecimalNumber[i]]);
		}

		return result.ToString().TrimStart('0');
	}
}
